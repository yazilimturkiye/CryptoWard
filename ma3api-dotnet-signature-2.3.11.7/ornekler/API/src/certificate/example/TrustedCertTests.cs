using System;
using System.Collections.Generic;
using ImzaApiTest.src.tr.gov.tubitak.uekae.esya.api;
using NUnit.Framework;
using tr.gov.tubitak.uekae.esya.api.asn.x509;
using tr.gov.tubitak.uekae.esya.api.certificate.validation;
using tr.gov.tubitak.uekae.esya.api.certificate.validation.find.certificate;
using tr.gov.tubitak.uekae.esya.api.certificate.validation.policy;

namespace tr.gov.tubitak.uekae.esya.api.src.certificate.example
{
    class TrustedCertTests : SampleBase
    {
        private static readonly string POLICY_FILE_NES = getRootDir() + @"\config\certval-policy-test.xml";
        private static readonly string POLICY_FILE_MM = getRootDir() + @"\config\certval-policy-malimuhur.xml";

        [Test]
        public void testListTrustedCertsForNES()
        {
            listTrustedCerts(POLICY_FILE_NES);
        }

        [Test]
        public void testListTrustedCertsForMM()
        {
            listTrustedCerts(POLICY_FILE_MM);
        }


        public void listTrustedCerts(String policyFile)
        {
            ValidationPolicy policy = PolicyReader.readValidationPolicy(policyFile);
            ValidationSystem validationSystem = CertificateValidation.createValidationSystem(policy);

            validationSystem.getFindSystem().findTrustedCertificates();
            List<ECertificate> trustedCertificates = validationSystem.getFindSystem().getTrustedCertificates();

            Console.WriteLine("Toplam Güvenilir Sertifika Adedi: " + trustedCertificates.Count);
            foreach (ECertificate aCert in trustedCertificates)
            {
                Console.WriteLine(aCert.ToString());
            }
        }

        [Test]
        public void listCertificates()
        {
            ValidationPolicy policy = PolicyReader.readValidationPolicy(POLICY_FILE_NES);
            ValidationSystem validationSystem = CertificateValidation.createValidationSystem(policy);

            CertificateFinder certificateFinder = validationSystem.getFindSystem().getCertificateFinders()[0];
            List<ECertificate> certificates = certificateFinder.findCertificate();

            Console.WriteLine("Toplam Sertifika Adedi: " + certificates.Count);
            foreach (ECertificate aCert in certificates) {
                Console.WriteLine(aCert.ToString());
            }
        }
    }
}
