using log4net;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;
using iaik.pkcs.pkcs11.wrapper;
using tr.gov.tubitak.uekae.esya.api.asn.x509;
using tr.gov.tubitak.uekae.esya.api.cmssignature;
using tr.gov.tubitak.uekae.esya.api.common;
using tr.gov.tubitak.uekae.esya.api.common.crypto;
using tr.gov.tubitak.uekae.esya.api.crypto.alg;
using tr.gov.tubitak.uekae.esya.api.smartcard.pkcs11;

namespace tr.gov.tubitak.uekae.esya.api.hsm.example
{
    /*
     * Her imzalama işleminde yeni bir session açılır ve login olunur.
     * Aktif Aktif Dirak HSM kullanımında her seferinde yeni bir session açıldığından rastgele bir şekilde işlemler HSM'ler arasında dağıtılmış olur.
     * Bir HSM'in hata durumuna düşmesi durumunda  Dirak HSM pkcs#11 kütüphanesi çalışır durumdaki HSM'den session açar.
     * */
    public class T2_HSMSignTest
    {
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [Test]
        public void signTest()
        {
            P11SmartCard sc = new P11SmartCard(TZ_HSMTestUtil.CARD_TYPE);
            for (int i = 0; i < 10; i++)
            {
                signWithRetry(sc, true);
            }
        }

        private void signWithRetry(P11SmartCard sc, bool retry)
        {
            try
            {
                sc.openSession(TZ_HSMTestUtil.SLOT_ID);
                sc.login(TZ_HSMTestUtil.SLOT_PIN);
                List<byte[]> certs = sc.getSmartCard().readCertificate(sc.getSessionNo(), TZ_HSMTestUtil.LABEL);

                if (certs.Count == 0)
                    throw new SmartCardException("No certificate found with the label: " + TZ_HSMTestUtil.LABEL);

                if (certs.Count > 1)
                    throw new SmartCardException("Multiple certificates found with the label: " + TZ_HSMTestUtil.LABEL + " Count: " + certs.Count);

                ECertificate cert = new ECertificate(certs[0]);
                SignatureAlg signatureAlg = SignatureAlg.getConvenientSignatureAlg(cert);

                BaseSigner signer = sc.getSigner(cert, signatureAlg.getName());

                new TZ_HSMTestUtil().signAndVerifyCAdES(signer, cert);

                sc.logout();
                sc.closeSession();
            }
            catch (Exception e) when (e is ESYAException || e is CMSSignatureException || e is PKCS11Exception)
            {
                if (retry)
                {
                    logger.Debug("Error at signing, trying again", e);
                    signWithRetry(sc, false);
                }
                else
                {
                    throw e;
                }
            }
        }
    }
}