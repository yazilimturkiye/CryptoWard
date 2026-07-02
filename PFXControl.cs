using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tr.gov.tubitak.uekae.esya.api.asn.x509;
using tr.gov.tubitak.uekae.esya.api.cmssignature;
using tr.gov.tubitak.uekae.esya.api.cmssignature.attribute;
using tr.gov.tubitak.uekae.esya.api.cmssignature.signature;
using tr.gov.tubitak.uekae.esya.api.common;
using tr.gov.tubitak.uekae.esya.api.crypto.alg;
using tr.gov.tubitak.uekae.esya.api.signature.util;

namespace CryptoWard
{
    public partial class PFXControl : UserControl
    {
        public PFXControl()
        {
            InitializeComponent();
        }

        private void ConfigureDigestOptions(X509Certificate2 cert) //Configure Digest Algorithm Options Based on Certificate Key Type
        {
            // Certificate Algorithm Auto Detection
            // Uses Microsoft X509 APIs
            // Purpose : Automatic digest selection for MA3 signing

            // Reset
            radioButton_PFXSHA256.Enabled = true;
            radioButton_PFXSHA384.Enabled = true;
            radioButton_PFXSHA512.Enabled = true;

            radioButton_PFXSHA256.Checked = false;
            radioButton_PFXSHA384.Checked = false;
            radioButton_PFXSHA512.Checked = false;

            string publicKeyOid = cert.PublicKey.Oid.Value;

            // =====================================================
            // RSA
            // =====================================================

            if (publicKeyOid == "1.2.840.113549.1.1.1")
            {
                radioButton_PFXSHA256.Checked = true;

                return;
            }

            // =====================================================
            // ECDSA
            // =====================================================

            if (publicKeyOid == "1.2.840.10045.2.1")
            {
                int keySize = 0;

                try
                {
                    if (cert.GetECDsaPublicKey() != null)
                    {
                        keySize =
                            cert.GetECDsaPublicKey().KeySize;
                    }
                }
                catch
                {
                }

                // =============================================
                // P-256
                // =============================================

                if (keySize <= 256)
                {
                    radioButton_PFXSHA256.Checked = true;

                    radioButton_PFXSHA384.Enabled = false;
                    radioButton_PFXSHA512.Enabled = false;

                    return;
                }

                // =============================================
                // P-384
                // =============================================

                if (keySize <= 384)
                {
                    radioButton_PFXSHA384.Checked = true;

                    radioButton_PFXSHA256.Enabled = false;
                    radioButton_PFXSHA512.Enabled = false;

                    return;
                }

                // =============================================
                // P-521
                // =============================================

                radioButton_PFXSHA512.Checked = true;

                radioButton_PFXSHA256.Enabled = false;
                radioButton_PFXSHA384.Enabled = false;

                return;
            }
        }

        private void AddPFXItems(string property, string value) //Add PFX Items to ListView
        {
            ListViewItem item = new ListViewItem(property);
            item.SubItems.Add(value);
            listView_PFX.Items.Add(item);
        }

        private void ShowPFXItems(X509Certificate2 cert) //Show PFX Items in ListView
        {
            // MA3API Used : NONE
            // Reason      : Certificate metadata inspection is better handled by
            //               Microsoft X509Certificate2 classes.
            listView_PFX.Items.Clear();

            AddPFXItems("Subject", cert.Subject);
            AddPFXItems("Issuer", cert.Issuer);
            AddPFXItems("Friendly Name",string.IsNullOrWhiteSpace(cert.FriendlyName)? "-": cert.FriendlyName);
            AddPFXItems("Thumbprint", cert.Thumbprint);
            AddPFXItems("Serial Number", cert.SerialNumber);
            AddPFXItems("Valid From", cert.NotBefore.ToString());
            AddPFXItems("Valid To", cert.NotAfter.ToString());
            AddPFXItems("Signature Algorithm",cert.SignatureAlgorithm?.FriendlyName ?? "-");
            AddPFXItems("Public Key Algorithm",cert.PublicKey?.Oid?.FriendlyName ?? "-");
            AddPFXItems("Public Key OID",cert.PublicKey?.Oid?.Value ?? "-");

            try
            {
                if (cert.PublicKey.Key != null)
                {
                    AddPFXItems("Key Size",cert.PublicKey.Key.KeySize + " bit");
                    AddPFXItems("Key Type",cert.PublicKey.Key.GetType().Name);
                }
            }
            catch
            {
                AddPFXItems("Key Info", "Cannot read key information");
            }
            AddPFXItems("Has Private Key",cert.HasPrivateKey.ToString());
            AddPFXItems("Certificate Format",cert.GetFormat());
        }

        private void button_Select_PFX_File_Click(object sender, EventArgs e) //Select PFX File
        {
            using (OpenFileDialog selectPFX = new OpenFileDialog())
            {
                selectPFX.Filter = "PFX Files (*.pfx)|*.pfx";
                selectPFX.Title = "Select PFX File";
                selectPFX.RestoreDirectory = true;
                selectPFX.CheckFileExists = true;
                selectPFX.Multiselect = false;

                if (selectPFX.ShowDialog() == DialogResult.OK)
                {
                    textBox_PFX_Path.Text = selectPFX.FileName;
                    button_PFX_Pass.Enabled = true;
                }
            }
        }

        private void button_Select_File_Click(object sender, EventArgs e) //Select File to Sign
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox_File_Path.Text = ofd.FileName;
                groupBox_SignatureFormat.Enabled = true;
                groupBox_SignatureType.Enabled = true;
                groupBox_HashAlgorithm.Enabled = true;
                button_Sign.Enabled = true;
            }
        }

        private void button_Sign_Click(object sender, EventArgs e)
        {
            // MA3API:
            // Namespace  : tr.gov.tubitak.uekae.esya.api.crypto.alg
            // Class      : SignatureAlg
            // Feature    : Dynamic Signature Algorithm Selection
            if (!MA3Environment.IsInitialized)
            {
                MessageBox.Show("MA3 Environment is not initialized! Go to Settings Tab.");
                return;
            }

            try
            {
                string pfxPath = textBox_PFX_Path.Text;
                string password = textBox_PFX_Pass.Text;
                string filePath = textBox_File_Path.Text;

                if (!File.Exists(pfxPath))
                {
                    MessageBox.Show("PFX file not found.");
                    return;
                }

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Document file not found.");
                    return;
                }

                // =========================================================
                // SIGNATURE FORMAT
                // =========================================================

                string signatureFormat = "";

                if (radioButton_PFXCAdES.Checked)
                {
                    signatureFormat = "CADES";
                }
                else if (radioButton_PFXPAdES.Checked)
                {
                    signatureFormat = "PADES";
                }
                else if (radioButton_PFXXAdES.Checked)
                {
                    signatureFormat = "XADES";
                }
                else
                {
                    MessageBox.Show("Please select signature format.");
                    return;
                }

                // =========================================================
                // CURRENT VERSION LIMITATION
                // =========================================================

                if (signatureFormat != "CADES")
                {
                    MessageBox.Show("Current version supports only CAdES signing.");
                    return;
                }

                // =========================================================
                // SIGNATURE TYPE
                // =========================================================

                bool detached = false;

                if (radioButton_PFXDetached.Checked)
                {
                    detached = true;
                }
                else if (radioButton_PFXAttached.Checked)
                {
                    detached = false;
                }
                else if (radioButton_PFXEnveloped.Checked)
                {
                    MessageBox.Show("Enveloped signature is only valid for XML/XAdES.");
                    return;
                }
                else
                {
                    MessageBox.Show("Please select signature type.");
                    return;
                }

                // =========================================================
                // DETECT CERTIFICATE KEY ALGORITHM
                // =========================================================

                X509Certificate2 x509 =
                    new X509Certificate2(
                        pfxPath,
                        password,
                        X509KeyStorageFlags.Exportable);

                bool isRSA = false;
                bool isECDSA = false;

                string publicKeyOid = x509.PublicKey.Oid.Value;

                // RSA
                if (publicKeyOid == "1.2.840.113549.1.1.1")
                {
                    isRSA = true;
                }
                // ECDSA
                else if (publicKeyOid == "1.2.840.10045.2.1")
                {
                    isECDSA = true;
                }
                else
                {
                    MessageBox.Show("Unsupported certificate algorithm.");
                    return;
                }

                // =========================================================
                // SELECT SIGNATURE ALGORITHM
                // =========================================================

                string signatureAlgorithm = "";

                if (isRSA)
                {
                    if (radioButton_PFXSHA256.Checked)
                    {
                        signatureAlgorithm = SignatureAlg.RSA_SHA256.getName();
                    }
                    else if (radioButton_PFXSHA384.Checked)
                    {
                        signatureAlgorithm = SignatureAlg.RSA_SHA384.getName();
                    }
                    else if (radioButton_PFXSHA512.Checked)
                    {
                        signatureAlgorithm = SignatureAlg.RSA_SHA512.getName();
                    }
                }
                else if (isECDSA)
                {
                    if (radioButton_PFXSHA256.Checked)
                    {
                        signatureAlgorithm = SignatureAlg.ECDSA_SHA256.getName();
                    }
                    else if (radioButton_PFXSHA384.Checked)
                    {
                        signatureAlgorithm = SignatureAlg.ECDSA_SHA384.getName();
                    }
                    else if (radioButton_PFXSHA512.Checked)
                    {
                        signatureAlgorithm = SignatureAlg.ECDSA_SHA512.getName();
                    }
                }

                if (string.IsNullOrWhiteSpace(signatureAlgorithm))
                {
                    MessageBox.Show("Please select digest algorithm.");
                    return;
                }

                // =========================================================
                // LOAD FILE
                // =========================================================

                byte[] fileBytes = File.ReadAllBytes(filePath);

                // =========================================================
                // CREATE SIGNED DATA
                // =========================================================

                BaseSignedData signedData = new BaseSignedData();

                ISignable content = new SignableByteArray(fileBytes);

                signedData.addContent(content);

                // =========================================================
                // SIGN PARAMETERS
                // =========================================================

                Dictionary<string, object> parameters =
                    new Dictionary<string, object>();

                parameters[
                    EParameters.P_VALIDATE_CERTIFICATE_BEFORE_SIGNING] = false;

                // =========================================================
                // CREATE PFX SIGNER
                // =========================================================

                PfxSigner signer = new PfxSigner(
                    signatureAlgorithm,
                    pfxPath,
                    password
                );

                if (signer == null)
                {
                    MessageBox.Show("Signer creation failed.");
                    return;
                }

                // =========================================================
                // LOAD CERTIFICATE
                // =========================================================

                ECertificate cert = signer.getSignersCertificate();

                if (cert == null)
                {
                    MessageBox.Show("Certificate could not be loaded.");
                    return;
                }

                // =========================================================
                // ADD SIGNER
                // =========================================================

                signedData.addSigner(ESignatureType.TYPE_BES,cert,signer,null,parameters
                );

                // =========================================================
                // ENCODE SIGNED DATA
                // =========================================================

                byte[] signedBytes = signedData.getEncoded();

                // =========================================================
                // OUTPUT FILE
                // =========================================================

                string outputPath = "";

                if (detached)
                {
                    outputPath = filePath + ".p7s";
                }
                else
                {
                    outputPath = filePath + ".p7m";
                }

                File.WriteAllBytes(outputPath, signedBytes);

                MessageBox.Show("Document signed successfully.\n\n" +outputPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Signing failed.\n\n" + ex.ToString());
            }
        }

        private void PFXControl_Load(object sender, EventArgs e)
        {

        }

        private void button_PFX_Pass_Click(object sender, EventArgs e)
        {
            try
            {
                string pfxPath = textBox_PFX_Path.Text;
                string password = textBox_PFX_Pass.Text;

                if (string.IsNullOrWhiteSpace(pfxPath))
                {
                    MessageBox.Show("Please select a PFX file.","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!File.Exists(pfxPath))
                {
                    MessageBox.Show("PFX file not found.","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                listView_PFX.Items.Clear();
                X509Certificate2Collection collection = new X509Certificate2Collection();
                collection.Import(pfxPath,password,X509KeyStorageFlags.Exportable);
                foreach (X509Certificate2 cert in collection)
                {
                    ShowPFXItems(cert);
                    ConfigureDigestOptions(cert);
                }
                button_Select_File.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid password or corrupted PFX.\n" + ex.Message,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
