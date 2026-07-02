using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using tr.gov.tubitak.uekae.esya.api.asn.x509;
using tr.gov.tubitak.uekae.esya.api.cmssignature;
using tr.gov.tubitak.uekae.esya.api.cmssignature.signature;
using tr.gov.tubitak.uekae.esya.api.common;
using tr.gov.tubitak.uekae.esya.api.signature;
using System.Diagnostics;


namespace CryptoWard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void EnableMainUI()
        {
            groupBox_Method.Visible = true;
            label_MainFormTitle.Visible = true;
            label_MainFormSubTitle.Visible = true;
            pictureBox_MainFormLogo.Visible = true;
            menuStrip1.Visible = true;
            radioButton_PFX.Checked = false;
            radioButton_SmartCard.Checked = false;
            panel_MainForm.Controls.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_MainForm.Controls.Clear();
            if (!MA3Environment.IsInitialized)
            {
                var SettingsControl = new SettingsControl();
                panel_MainForm.Controls.Add(SettingsControl);
                return;
            }
            else
            {
                groupBox_Method.Enabled = true;
                label_MainFormTitle.Enabled = true;
                pictureBox_MainFormLogo.Enabled = true;
                menuStrip1.Enabled = true;
            }
        }

        private void radioButton_PFX_CheckedChanged(object sender, EventArgs e)
        {
            panel_MainForm.Controls.Clear();
            var pfxControl = new PFXControl();
            panel_MainForm.Controls.Add(pfxControl);
        }

        private void toolStripMenuItem_Settings_Click(object sender, EventArgs e)
        {
            panel_MainForm.Controls.Clear();
            var SettingsControl = new SettingsControl();
            panel_MainForm.Controls.Add(SettingsControl);
            groupBox_Method.Visible = false;
        }

        private void radioButton_SmartCard_CheckedChanged(object sender, EventArgs e)
        {
            panel_MainForm.Controls.Clear();
            var SCControl = new SCControl();
            panel_MainForm.Controls.Add(SCControl);
        }

        private void toolStripMenuItem_About_Click(object sender, EventArgs e)
        {
            label_MainFormTitle.Visible = false;
            label_MainFormSubTitle.Visible = false;
            pictureBox_MainFormLogo.Visible = false;
            panel_MainForm.Controls.Clear();
            var AboutControl = new AboutControl();
            panel_MainForm.Controls.Add(AboutControl);
            groupBox_Method.Visible = false;
        }

        private void linkLabel_yazilimturk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://www.yazilimturkiye.com",
                    UseShellExecute = true
                });

                linkLabel_yazilimturk.LinkVisited = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open the website.\n\n" + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
