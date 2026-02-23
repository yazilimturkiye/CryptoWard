using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tr.gov.tubitak.uekae.esya.api.asn.x509;
using tr.gov.tubitak.uekae.esya.api.cmssignature;
using tr.gov.tubitak.uekae.esya.api.cmssignature.attribute;
using tr.gov.tubitak.uekae.esya.api.cmssignature.signature;
using tr.gov.tubitak.uekae.esya.api.common;
using tr.gov.tubitak.uekae.esya.api.signature.util;
using tr.gov.tubitak.uekae.esya.api.crypto.alg;

namespace CryptoWard
{
    public partial class PFXControl : UserControl
    {
        public PFXControl()
        {
            InitializeComponent();
        }

        private void button_Select_PFX_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PFX Files (*.pfx)|*.pfx";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox_PFX_Path.Text = ofd.FileName;
            }
        }

        private void button_Select_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox_File_Path.Text = ofd.FileName;
            }
        }

        private void button_Sign_Click(object sender, EventArgs e)
        {
            try
            {
                string pfxPath = textBox_PFX_Path.Text;
                string password = textBox_PFX_Pass.Text;
                string filePath = textBox_File_Path.Text;

                if (!File.Exists(pfxPath))
                {
                    MessageBox.Show("PFX dosyası bulunamadı.");
                    return;
                }

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("İmzalanacak dosya bulunamadı.");
                    return;
                }

                byte[] fileBytes = File.ReadAllBytes(filePath);

                BaseSignedData baseSignedData = new BaseSignedData();

                ISignable content = new SignableByteArray(fileBytes);
                baseSignedData.addContent(content);

                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters[EParameters.P_VALIDATE_CERTIFICATE_BEFORE_SIGNING] = false;

                // Eğer enum varsa bunu kullan:
                // PfxSigner signer = new PfxSigner(SignatureAlgorithm.RSA_SHA256, pfxPath, password);

                PfxSigner signer = new PfxSigner(
                    SignatureAlg.RSA_SHA256.getName(),
                    pfxPath,
                    password
                );

                if (signer == null)
                {
                    MessageBox.Show("Signer oluşturulamadı.");
                    return;
                }

                ECertificate cert = signer.getSignersCertificate();

                if (cert == null)
                {
                    MessageBox.Show("Sertifika yüklenemedi. Şifre yanlış olabilir.");
                    return;
                }

                baseSignedData.addSigner(
                    ESignatureType.TYPE_BES,
                    cert,
                    signer,
                    null,
                    parameters
                );

                byte[] signedDocument = baseSignedData.getEncoded();

                string outputPath = filePath + ".p7s";

                File.WriteAllBytes(outputPath, signedDocument);

                MessageBox.Show("BES imza oluşturuldu.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata:\n" + ex.ToString());
            }
        }

        private void PFXControl_Load(object sender, EventArgs e)
        {

        }
    }
}
