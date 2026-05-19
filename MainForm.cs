using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tr.gov.tubitak.uekae.esya.api.cmssignature;
using tr.gov.tubitak.uekae.esya.api.cmssignature.signature;
using tr.gov.tubitak.uekae.esya.api.signature;
using tr.gov.tubitak.uekae.esya.api.asn.x509;
using tr.gov.tubitak.uekae.esya.api.common;


namespace CryptoWard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                label1.Enabled = true;
                pictureBox1.Enabled = true;
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
        }
    }
}
