using ImzaApiTest.src.tr.gov.tubitak.uekae.esya.api;
using NUnit.Framework;
using System.Collections.Generic;
using tr.gov.tubitak.uekae.esya.api.asn.pkcs1pkcs8;
using tr.gov.tubitak.uekae.esya.api.asn.x509;
using tr.gov.tubitak.uekae.esya.api.common.util.bag;
using tr.gov.tubitak.uekae.esya.api.crypto;
using tr.gov.tubitak.uekae.esya.api.crypto.provider.core.baseTypes;
using tr.gov.tubitak.uekae.esya.api.smartcard.pkcs11;

namespace tr.gov.tubitak.uekae.esya.api.hsm.example
{
    public class T1_LoadPfxToHSM : SampleBase
    {
        [Test]
        public void writePfxToHSM()
        {
            SmartCard sc = new SmartCard(TZ_HSMTestUtil.CARD_TYPE);
            long session = sc.openSession(TZ_HSMTestUtil.SLOT_ID);
            //PIN
            sc.login(session, TZ_HSMTestUtil.SLOT_PIN);

            //Pfx okunuyor.
            IPfxParser pfxParser = Crypto.getPfxParser();
            pfxParser.loadPfx(getPFXPath(), getPFX_PIN());
            List<Pair<ECertificate, IPrivateKey>> entries = pfxParser.getCertificatesAndKeys();

            foreach (Pair<ECertificate, IPrivateKey> pair in entries)
            {
                ECertificate cert = pair.getmObj1();
                EPrivateKeyInfo privateKeyInfo = new EPrivateKeyInfo(pair.getmObj2().getEncoded());
                ESubjectPublicKeyInfo subjectPublicKeyInfo = cert.getSubjectPublicKeyInfo();

                //Anahtar çifti ve sertifika karta yükleniyor.
                sc.importKeyPair(session, TZ_HSMTestUtil.LABEL, subjectPublicKeyInfo, privateKeyInfo, null, null, true, false);
                sc.importCertificate(session, TZ_HSMTestUtil.LABEL, cert);
            }

            sc.logout(session);
            sc.closeSession(session);
        }

        [Test]
        public void deleteObjects()
        {
            P11SmartCard sc = new P11SmartCard(TZ_HSMTestUtil.CARD_TYPE);
            //Dogrudan ilk karta baglanılıyor.
            sc.openSession(TZ_HSMTestUtil.SLOT_ID);
            //PIN
            sc.login(TZ_HSMTestUtil.SLOT_PIN);

            sc.getSmartCard().deleteCertificate(sc.getSessionNo(), TZ_HSMTestUtil.LABEL);
            sc.getSmartCard().deletePublicObject(sc.getSessionNo(), TZ_HSMTestUtil.LABEL);
            sc.getSmartCard().deletePrivateObject(sc.getSessionNo(), TZ_HSMTestUtil.LABEL);

            sc.logout();
            sc.closeSession();
        }
    }
}
