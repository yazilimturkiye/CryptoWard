using log4net;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;
using tr.gov.tubitak.uekae.esya.api.asn.x509;
using tr.gov.tubitak.uekae.esya.api.cades.example;
using tr.gov.tubitak.uekae.esya.api.common.crypto;
using tr.gov.tubitak.uekae.esya.api.crypto.alg;
using tr.gov.tubitak.uekae.esya.api.crypto.util;
using tr.gov.tubitak.uekae.esya.api.smartcard.pkcs11;
using tr.gov.tubitak.uekae.esya.api.smartcard.util;

namespace tr.gov.tubitak.uekae.esya.api.hsm.example
{
    /*
     * HSM'de bir kere session acilip ve login olunduktan sonra butun islemlerde ayni sessionId kullanilir.
     * Bu siniftaki ornekde tek bir sertifika/anahtar icin bir cache yapisi kullanilmistir. Farkli anahtarla islem yapilacaksa coklu cache yapisina gore duzenleme
     * yapilmali veya HSMSessionPool yapisi kullanilmali.
     * Performans arttirimi icin multithread bir yapi kullanilabilir. Her bir thread icin farkli session kullanilmasi gerektigi icin farkli BaseSigner nesnesi
     * kullanilmalidir.
     * Imzalama isleminde hata alindigi durumda yeni bir session acma ve login sureci isletilip imzalama islemi tekrar denenir.
     * Aktif Aktif Dirak HSM kullaniminda her seferinde ayni session kullanilacagi icin hata alinmadigi surece ayni HSM kullanilacaktir. Hata alinmasi durumunda
     * eger HSM'lerden biri hata durumuna dustu ise dirak pkcs#11 kutuphanesi calisir durumdaki HSM'den session acacaktir.
     * */
    public class T3_HSMSignTestWithCache : CadesSampleBase
    {
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static readonly object _lock = new object();

        public static String cachedLabel;
        public static ECertificate cachedCert;
        public static BaseSigner cachedSigner;

        [Test]
        public void CAdESSignTest()
        {
            for (int i = 0; i < 10; i++)
            {
                cadesSign(TZ_HSMTestUtil.LABEL);
            }
        }

        public void cadesSign(String label)
        {
            lock (_lock)
            {
                try
                {
                    initCache(label);
                    new TZ_HSMTestUtil().signAndVerifyCAdES(cachedSigner, cachedCert);
                }
                catch (SmartCardException)
                {
                    logger.Debug("Signing failed. Will be tried with new HSM session.");
                    cachedLabel = null;

                    initCache(label);
                    new TZ_HSMTestUtil().signAndVerifyCAdES(cachedSigner, cachedCert);
                }
            }
        }

        [Test]
        public void HSMRawSignTest()
        {
            byte[] bytes = RandomUtil.generateRandom(32);
            for (int i = 0; i < 100; i++)
            {
                hsmRawSign(TZ_HSMTestUtil.LABEL, bytes);
            }
        }

        public void hsmRawSign(String label, byte[] data)
        {
            try
            {
                initCache(label);
                cachedSigner.sign(data);
            }
            catch (SmartCardException e)
            {
                logger.Debug("Signing failed. Will be tried with new HSM session.");
                cachedLabel = null;
                initCache(label);
                cachedSigner.sign(data);
            }
        }

        private void initCache(String label)
        {
            if (String.IsNullOrEmpty(label))
                throw new SmartCardException("label can not be null or empty for signing!");

            if (!label.Equals(cachedLabel))
            {
                logger.Debug("Creating cache. Requested Label: " + label + ", Already Cached: " + cachedLabel);
                cachedCert = null;
                cachedSigner = null;
            }

            if (cachedCert != null && cachedSigner != null)
            {
                //Already initialized for requested label.
                return;
            }

            P11SmartCard sc = new P11SmartCard(TZ_HSMTestUtil.CARD_TYPE);
            sc.openSession(TZ_HSMTestUtil.SLOT_ID);
            sc.login(TZ_HSMTestUtil.SLOT_PIN);

            List<byte[]> certs = sc.getSmartCard().readCertificate(sc.getSessionNo(), label);

            if (certs.Count == 0)
                throw new SmartCardException("No certificate found with the label: " + label);

            if (certs.Count > 1)
                throw new SmartCardException("Multiple certificates found with the label: " + label + " Count: " + certs.Count);

            ECertificate cert = new ECertificate(certs[0]);

            SignatureAlg signatureAlg = SignatureAlg.getConvenientSignatureAlg(cert);

            SCSignerWithKeyLabel signer = new SCSignerWithKeyLabel(sc.getSmartCard(), sc.getSessionNo(), TZ_HSMTestUtil.SLOT_ID, label, signatureAlg.getName());

            cachedLabel = label;
            cachedCert = cert;
            cachedSigner = signer;
        }
    }
}
