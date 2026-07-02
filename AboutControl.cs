using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoWard
{
    public partial class AboutControl : UserControl
    {
        public AboutControl()
        {
            InitializeComponent();
        }

        private void button_AboutOK_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)this.FindForm();
            mainForm.EnableMainUI();
            Panel panel = (Panel)this.Parent;
        }

        private void linkLabel_YazilimTurk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://www.yazilimturkiye.com",
                    UseShellExecute = true
                });

                linkLabel_YazilimTurk.LinkVisited = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open the website.\n\n" + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void linkLabel_YazilimKamuSM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://yazilim.kamusm.gov.tr/",
                    UseShellExecute = true
                });

                linkLabel_YazilimTurk.LinkVisited = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open the website.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
