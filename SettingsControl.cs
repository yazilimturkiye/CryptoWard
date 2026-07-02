using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
                string content = File.ReadAllText(licensePath);
                string startTag = "<LisansID>";
                string endTag = "</LisansID>";
                int start = content.IndexOf(startTag);
                int end = content.IndexOf(endTag);
                if (start == -1 || end == -1)
                {
                    return "-";
                }
                start += startTag.Length;
                return content.Substring(start, end - start).Trim();
            }
            catch
            {
                return "-";
            }
        }

        private void SettingsControl_Load(object sender, EventArgs e)
        {
            if (AppSession.MA3Initialized)
            {
                textbox_LicensePath.Text = AppSession.LicensePath;
                textBox_APILisanceDate.Text = AppSession.LicenseDate;
                textBox_APILisanceID.Text = AppSession.LicenseID;
                label_APIState.ForeColor = Color.Green;
                label_APIState.Text = "MA3 API initialized successfully!";
                button_SelectLicense.Enabled = false;
                button_LoadLicense.Enabled = false;
                button_Next.Enabled = true;
            }
        }

        private void button_LoadLicense_Click(object sender, EventArgs e)
        {
            bool result =MA3Environment.Initialize(textbox_LicensePath.Text);

            if (result)
            {
                AppSession.MA3Initialized = true;
                AppSession.LicensePath = textbox_LicensePath.Text;
                AppSession.LicenseDate = MA3Environment.LicenseExpirationDate.ToShortDateString();
                AppSession.LicenseID = GetLicenseID(MA3Environment.LoadedLicensePath);
                textBox_APILisanceDate.Text = AppSession.LicenseDate;
                textBox_APILisanceID.Text = AppSession.LicenseID;
                label_APIState.ForeColor = Color.Green;
                label_APIState.Text = "MA3 API initialized successfully!";
                button_SelectLicense.Enabled = false;
                button_LoadLicense.Enabled = false;
                button_Next.Enabled = true;
            }
            else
            {
                AppSession.MA3Initialized = false;
                MessageBox.Show("MA3 initialization failed!\n\n" +"If you do not have a license or " +"configuration information, " +"please contact:\n\n" +"https://yazilim.kamusm.gov.tr/","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
                    button_LoadLicense.Enabled = true;
                }
            }
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.EnableMainUI();
            Panel panel = (Panel)this.Parent;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://yazilim.kamusm.gov.tr/",
                    UseShellExecute = true
                });

                linkLabel1.LinkVisited = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open the website.\n\n" + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
