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
using tr.gov.tubitak.uekae.esya.api.common.util.bag;
using tr.gov.tubitak.uekae.esya.api.crypto.alg;
using tr.gov.tubitak.uekae.esya.api.smartcard;
using tr.gov.tubitak.uekae.esya.api.smartcard.pkcs11;
using tr.gov.tubitak.uekae.esya.api.smartcard.util;

namespace CryptoWard
{
    public partial class SCControl : UserControl
    {
        public SCControl()
        {
            InitializeComponent();
        }
        private SmartCard _smartCard;
        private long _session;
        private long _slot;
        private CardType _cardType;
        private List<ECertificate> _certificates = new List<ECertificate>();
        private ECertificate _selectedCertificate;
        private X509Certificate2 _selectedX509Certificate;

        public enum SignatureFormat
        {
            CAdES,
            PAdES,
            XAdES
        }

        private void ValidateSigningInputs()
        {
            // MA3API Used : NONE
            // Reason      : UI validation before calling MA3API.

            if (string.IsNullOrWhiteSpace(textBox_SCFilePath.Text))
                throw new Exception("Please select a file to sign.");

            if (!System.IO.File.Exists(textBox_SCFilePath.Text))
                throw new Exception("Selected file does not exist.");

            if (_smartCard == null)
                throw new Exception("Smart card is not initialized.");

            if (_session <= 0)
                throw new Exception("Smart card session is not opened.");

            if (_selectedCertificate == null)
                throw new Exception("Please select a signing certificate.");

            if (comboBox_SCReaders.SelectedIndex < 0)
                throw new Exception("Please select a smart card reader.");
        }

        private SignatureAlg GetSelectedSignatureAlgorithm()
        {
            // =====================================================
            // MA3API:
            // Class  : SignatureAlg
            // Purpose: Returns the selected signature algorithm.
            // =====================================================

            bool isECDSA = _selectedX509Certificate.PublicKey.Oid.Value == "1.2.840.10045.2.1";

            if (radioButton_SCSHA256.Checked)
                return isECDSA
                    ? SignatureAlg.ECDSA_SHA256
                    : SignatureAlg.RSA_SHA256;

            if (radioButton_SCSHA384.Checked)
                return isECDSA
                    ? SignatureAlg.ECDSA_SHA384
                    : SignatureAlg.RSA_SHA384;

            if (radioButton_SCSHA512.Checked)
                return isECDSA
                    ? SignatureAlg.ECDSA_SHA512
                    : SignatureAlg.RSA_SHA512;

            throw new Exception("Please select a digest algorithm.");
        }

        private SignatureFormat GetSelectedSignatureFormat()
        {
            if (radioButton_SCCAdES.Checked)
                return SignatureFormat.CAdES;

            if (radioButton_SCPAdES.Checked)
                return SignatureFormat.PAdES;

            if (radioButton_SCXAdES.Checked)
                return SignatureFormat.XAdES;

            throw new Exception("Please select a signature format.");
        }

        private BaseSignedData CreateSignedData()
        {
            // =====================================================
            // MA3API:
            // Class  : BaseSignedData
            // Class  : SignableByteArray
            // Purpose: Creates a signable CMS object from the selected file.
            // =====================================================

            string filePath = textBox_SCFilePath.Text;
            byte[] fileBytes = File.ReadAllBytes(filePath);
            BaseSignedData signedData = new BaseSignedData();
            ISignable content = new SignableByteArray(fileBytes);
            signedData.addContent(content);
            return signedData;
        }

        private SCSignerWithCertSerialNo CreateSmartCardSigner(SignatureAlg signatureAlgorithm)
        {
            // =====================================================
            // MA3API:
            // Class  : SCSignerWithCertSerialNo
            // Purpose: Creates a Smart Card signer using the
            //          selected certificate and current session.
            // =====================================================

            return new SCSignerWithCertSerialNo(_smartCard,_session,_slot,_selectedCertificate.getSerialNumber().GetData(),signatureAlgorithm.getName());
        }

        private void AddSmartCardSigner(BaseSignedData signedData,SCSignerWithCertSerialNo signer)
        {
            // =====================================================
            // MA3API:
            // Class  : BaseSignedData
            // Method : addSigner()
            //
            // MA3API:
            // Class  : ESignatureType
            //
            // MA3API:
            // Class  : SCSignerWithCertSerialNo
            // =====================================================

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters[EParameters.P_VALIDATE_CERTIFICATE_BEFORE_SIGNING] = false;

            signedData.addSigner(ESignatureType.TYPE_BES,_selectedCertificate,signer,null,parameters);
        }

        private void SaveSignedDocument(BaseSignedData signedData)
        {
            // =====================================================
            // MA3API:
            // Class  : BaseSignedData
            // Method : getEncoded()
            // Purpose: Generates the signed CMS document and saves it.
            // =====================================================

            byte[] signedDocument = signedData.getEncoded();

            string inputFile = textBox_SCFilePath.Text;

            string outputFile = inputFile + ".p7s";

            File.WriteAllBytes(outputFile,signedDocument);

            MessageBox.Show("Document signed successfully.\n\n" +outputFile,"Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void AddItem(string property,string value) // Helper method to add a property and its value to the ListView for displaying certificate information.
        {
            ListViewItem item = new ListViewItem(property);
            item.SubItems.Add(value);
            listView_SCCertificateInfo.Items.Add(item);
            button_SCSelectFile.Enabled = true;
        }

        private void ShowCertificateInfo(ECertificate cert) // Display the details of the selected certificate in the ListView when a certificate is selected from the combo box.
        {
            listView_SCCertificateInfo.Items.Clear();
            AddItem("Subject CN",cert.getSubject().getCommonNameAttribute());
            AddItem("Issuer CN",cert.getIssuer().getCommonNameAttribute());
            AddItem("Common Name",cert.getSubject().getCommonNameAttribute());
            AddItem("Serial Number",cert.getSerialNumberHex());
            AddItem("Valid From",cert.getNotBefore().ToString());
            AddItem("Valid To",cert.getNotAfter().ToString());
            AddItem("Qualified Certificate",cert.isQualifiedCertificate().ToString());
        }

        private void ConfigureSmartCardDigestOptions(X509Certificate2 cert)
        {
            // Reset
            radioButton_SCSHA256.Checked = false;
            radioButton_SCSHA384.Checked = false;
            radioButton_SCSHA512.Checked = false;
            string publicKeyOid = cert.PublicKey.Oid.Value;
            // =====================================================
            // RSA
            // =====================================================
            if (publicKeyOid == "1.2.840.113549.1.1.1")
            {
                radioButton_SCSHA256.Checked = true;
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
                    using (ECDsa ecdsa = cert.GetECDsaPublicKey())
                    {
                        if (ecdsa != null)
                        {
                            keySize = ecdsa.KeySize;
                        }
                    }
                }
                catch
                {
                }
                // P-256
                if (keySize <= 256)
                {
                    radioButton_SCSHA256.Checked = true;
                    radioButton_SCSHA384.Enabled = false;
                    radioButton_SCSHA512.Enabled = false;
                    return;
                }
                // P-384
                if (keySize <= 384)
                {
                    radioButton_SCSHA384.Checked = true;
                    radioButton_SCSHA256.Enabled = false;
                    radioButton_SCSHA512.Enabled = false;
                    return;
                }
                // P-521
                radioButton_SCSHA512.Checked = true;
                radioButton_SCSHA256.Enabled = false;
                radioButton_SCSHA384.Enabled = false;
            }
        }

        private void LoadReaders() // Load the list of available smart card readers into the combo box.
        {
            // MA3API:
            // Class  : SmartOp
            // Method : getCardTerminals()
            try
            {
                comboBox_SCReaders.Items.Clear();
                comboBox_SCCertificates.Items.Clear();
                listView_SCCertificateInfo.Items.Clear();
                textBox_SCPin.Clear();
                string[] terminals =SmartOp.getCardTerminals();
                if (terminals == null || terminals.Length == 0)
                {
                    MessageBox.Show("No smart card reader found.","No Readers Found!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                foreach (string terminal in terminals)
                {
                    comboBox_SCReaders.Items.Add(terminal);
                }
                comboBox_SCReaders.SelectedIndex = 0;
                textBox_SCPin.Enabled = true;
                button_SCUnlock.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Reader enumeration failed.\n\n" + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void SCControl_Load(object sender, EventArgs e)
        {
            LoadReaders(); // Load the list of smart card readers when the control is loaded.
        }

        private void button_SCRefreshReaders_Click(object sender, EventArgs e)
        {
            LoadReaders(); // Refresh the list of smart card readers when the button is clicked.
        }

        private void button_SCUnlock_Click(object sender, EventArgs e)
        {
            // MA3API:
            // Class  : SmartOp
            // Method : getSlotAndCardType()

            // MA3API:
            // Class  : SmartCard
            // Methods:
            // openSession()
            // login()
            // getSignatureCertificates()

            try
            {
                if (comboBox_SCReaders.SelectedItem == null)
                {
                    MessageBox.Show("Please select a smart card reader.","No Readers Found!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string selectedReader =comboBox_SCReaders.SelectedItem.ToString();
                string pin = textBox_SCPin.Text;
                if (string.IsNullOrWhiteSpace(pin))
                {
                    MessageBox.Show("Please enter smart card PIN.", "PIN Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Pair<long, CardType> slotAndCardType = SmartOp.getSlotAndCardType(selectedReader);
                _slot = slotAndCardType.getmObj1();
                _cardType = slotAndCardType.getmObj2();
                _smartCard = new SmartCard(_cardType);
                _session = _smartCard.openSession(_slot);
                _smartCard.login(_session,pin);

                List<byte[]> certBytes = _smartCard.getSignatureCertificates(_session);
                comboBox_SCCertificates.Items.Clear();
                _certificates.Clear();

                foreach (byte[] bs in certBytes)
                {
                    ECertificate cert = new ECertificate(bs);
                    _certificates.Add(cert);
                    comboBox_SCCertificates.Items.Add(cert.getSubject().getCommonNameAttribute());
                }

                if (comboBox_SCCertificates.Items.Count > 0)
                {
                    comboBox_SCCertificates.SelectedIndex = 0;
                    ShowCertificateInfo(_certificates[0]);
                }
                comboBox_SCCertificates.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Smart card login failed.\n\n" + ex.Message, "Login Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (comboBox_SCCertificates.SelectedIndex < 0)
                return;

            _selectedCertificate =_certificates[comboBox_SCCertificates.SelectedIndex];
            _selectedX509Certificate = new X509Certificate2(_selectedCertificate.getEncoded());
            ShowCertificateInfo(_selectedCertificate);
            ConfigureSmartCardDigestOptions(_selectedX509Certificate);
        }

        private void comboBox_SCCertificates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_SCCertificates.SelectedIndex < 0)
                return;

            _selectedCertificate = _certificates[comboBox_SCCertificates.SelectedIndex];
            _selectedX509Certificate = new X509Certificate2(_selectedCertificate.getEncoded());
            ShowCertificateInfo(_selectedCertificate);
            ConfigureSmartCardDigestOptions(_selectedX509Certificate);
        }

        private void button_SCSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox_SCFilePath.Text = ofd.FileName;
                groupBox_SCDigest.Enabled = true;
                groupBox_SCSignatureFormat.Enabled = true;
                groupBox_SCSignatureType.Enabled = true;
                button_SCSign.Enabled = true;
            }
        }

        private void button_SCSign_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateSigningInputs();
                SignatureAlg signatureAlgorithm = GetSelectedSignatureAlgorithm();
                SignatureFormat signatureFormat = GetSelectedSignatureFormat();
                BaseSignedData signedData = CreateSignedData();
                SCSignerWithCertSerialNo signer = CreateSmartCardSigner(signatureAlgorithm);

                AddSmartCardSigner(signedData,signer);

                SaveSignedDocument(signedData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Signing Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
