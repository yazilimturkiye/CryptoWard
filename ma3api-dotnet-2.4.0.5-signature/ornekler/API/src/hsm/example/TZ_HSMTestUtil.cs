using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using tr.gov.tubitak.uekae.esya.api.asn.x509;
using tr.gov.tubitak.uekae.esya.api.cades.example;
using tr.gov.tubitak.uekae.esya.api.cmssignature;
using tr.gov.tubitak.uekae.esya.api.cmssignature.attribute;
using tr.gov.tubitak.uekae.esya.api.cmssignature.signature;
using tr.gov.tubitak.uekae.esya.api.cmssignature.validation;
using tr.gov.tubitak.uekae.esya.api.common;
using tr.gov.tubitak.uekae.esya.api.common.crypto;
using tr.gov.tubitak.uekae.esya.api.smartcard.pkcs11;

namespace tr.gov.tubitak.uekae.esya.api.hsm.example
{
    public class TZ_HSMTestUtil : CadesSampleBase
    {
        public static CardType CARD_TYPE = CardType.DIRAKHSM;
        public static long SLOT_ID = 22;
        public static String SLOT_PIN = "12345678";

        public static String LABEL = "HSMSignTest";

        public TZ_HSMTestUtil()
        {
            beSureHsmConfigIsSet();
        }

        private static void beSureHsmConfigIsSet()
        {
            throw new ESYARuntimeException("Update the HSM settings in this class before use.");
        }

        public byte[] signCAdES(BaseSigner signer, ECertificate cert, bool validateCert)
        {
            BaseSignedData baseSignedData = new BaseSignedData();
            ISignable content = new SignableByteArray(Encoding.ASCII.GetBytes("test"));
            baseSignedData.addContent(content);
            Dictionary<string, object> _params = new Dictionary<string, object>();

            _params[EParameters.P_VALIDATE_CERTIFICATE_BEFORE_SIGNING] = validateCert;

            if (validateCert)
            {
                _params[EParameters.P_CERT_VALIDATION_POLICY] = getPolicy();
            }
            else
            {
                //If certificate validation is disabled, the certificate dates are checked quickly.
                if (cert.isDatesValid() == false)
                    throw new CMSSignatureException("Certificate dates is not valid: " + cert.ToString());
            }
            baseSignedData.addSigner(ESignatureType.TYPE_BES, cert, signer, null, _params);

            byte[] signedDocument = baseSignedData.getEncoded();

            return signedDocument;
        }

        public void signAndVerifyCAdES(BaseSigner signer, ECertificate cert)
        {
            BaseSignedData baseSignedData = new BaseSignedData();
            ISignable content = new SignableByteArray(Encoding.ASCII.GetBytes("test"));
            baseSignedData.addContent(content);
            Dictionary<string, object> _params = new Dictionary<string, object>();

            _params[EParameters.P_VALIDATE_CERTIFICATE_BEFORE_SIGNING] = false;

            baseSignedData.addSigner(ESignatureType.TYPE_BES, cert, signer, null, _params);


            byte[] signedDocument = baseSignedData.getEncoded();

            Dictionary<string, object> verifyParams = new Dictionary<string, object>();

            verifyParams[EParameters.P_CERT_VALIDATION_POLICY] = getPolicy();

            SignedDataValidation sdv = new SignedDataValidation();
            SignedDataValidationResult validationResult = sdv.verify(signedDocument, verifyParams);

            Assert.AreEqual(SignedData_Status.ALL_VALID, validationResult.getSDStatus());
        }
    }
}
