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
using System.Xml;
using System.Xml.Linq;
using tr.gov.tubitak.uekae.esya.api.xmlsignature.document;

namespace CryptoWard
{
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();
        }

        private string GetLicenseID(string licensePath)
        {
            try
            {
                string content =
                    File.ReadAllText(licensePath);

                string startTag = "<LisansID>";
                string endTag = "</LisansID>";

                int start =
                    content.IndexOf(startTag);

                int end =
                    content.IndexOf(endTag);

                if (start == -1 || end == -1)
                {
                    return "-";
                }

                start += startTag.Length;

                return content
                    .Substring(start, end - start)
                    .Trim();
            }
            catch
            {
                return "-";
            }
        }

        private void SettingsControl_Load(object sender, EventArgs e)
        {

        }

        private void button_LoadLicense_Click(object sender, EventArgs e)
        {
            bool result =MA3Environment.Initialize(textbox_LicensePath.Text);

            if (result)
            {
                textBox_APILisanceDate.Text = MA3Environment.LicenseExpirationDate.ToShortDateString();
                textBox_APILisanceID.Text = GetLicenseID(MA3Environment.LoadedLicensePath);
                label_APIState.ForeColor = Color.Green;
                label_APIState.Text = "MA3 API initialized successfully!";
                button_SelectLicense.Enabled = false;
                button_LoadLicense.Enabled = false;
                button_Next.Enabled = true;

            }
            else
            {
                MessageBox.Show("MA3 initialization failed!","Warning",MessageBoxButtons.OK);
            }
        }

        private void button_SelectLicense_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter ="XML Files (*.xml)|*.xml|All Files (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textbox_LicensePath.Text = ofd.FileName;
                }
            }
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            Form1 MainForm = new Form1();
            MainForm.Show();
            this.Hide();
        }
    }
}
