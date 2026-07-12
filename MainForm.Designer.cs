namespace CryptoWard
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_MainFormTitle = new System.Windows.Forms.Label();
            this.label_MainFormSubTitle = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel_MainForm = new System.Windows.Forms.Panel();
            this.linkLabel_yazilimturk = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox_Method = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton_SmartCard = new System.Windows.Forms.RadioButton();
            this.radioButton_PFX = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox_MainFormLogo = new System.Windows.Forms.PictureBox();
            this.groupBox_Method.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MainFormLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_MainFormTitle
            // 
            this.label_MainFormTitle.AutoSize = true;
            this.label_MainFormTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MainFormTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_MainFormTitle.Location = new System.Drawing.Point(56, 29);
            this.label_MainFormTitle.Name = "label_MainFormTitle";
            this.label_MainFormTitle.Size = new System.Drawing.Size(153, 28);
            this.label_MainFormTitle.TabIndex = 1;
            this.label_MainFormTitle.Text = "CryptoWard";
            this.label_MainFormTitle.Visible = false;
            // 
            // label_MainFormSubTitle
            // 
            this.label_MainFormSubTitle.AutoSize = true;
            this.label_MainFormSubTitle.Location = new System.Drawing.Point(58, 58);
            this.label_MainFormSubTitle.Name = "label_MainFormSubTitle";
            this.label_MainFormSubTitle.Size = new System.Drawing.Size(141, 20);
            this.label_MainFormSubTitle.TabIndex = 2;
            this.label_MainFormSubTitle.Text = "Digital Signing Tool\r\n";
            this.label_MainFormSubTitle.Visible = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "PFX1.fw.png");
            this.ımageList1.Images.SetKeyName(1, "HSM1.fw.png");
            this.ımageList1.Images.SetKeyName(2, "Settings.fw.png");
            this.ımageList1.Images.SetKeyName(3, "SmartCard1.fw.png");
            this.ımageList1.Images.SetKeyName(4, "SmartCard2.fw.png");
            // 
            // panel_MainForm
            // 
            this.panel_MainForm.Location = new System.Drawing.Point(12, 124);
            this.panel_MainForm.Name = "panel_MainForm";
            this.panel_MainForm.Size = new System.Drawing.Size(959, 550);
            this.panel_MainForm.TabIndex = 4;
            // 
            // linkLabel_yazilimturk
            // 
            this.linkLabel_yazilimturk.AutoSize = true;
            this.linkLabel_yazilimturk.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel_yazilimturk.Location = new System.Drawing.Point(832, 682);
            this.linkLabel_yazilimturk.Name = "linkLabel_yazilimturk";
            this.linkLabel_yazilimturk.Size = new System.Drawing.Size(140, 20);
            this.linkLabel_yazilimturk.TabIndex = 7;
            this.linkLabel_yazilimturk.TabStop = true;
            this.linkLabel_yazilimturk.Text = "yazilimturkiye.com";
            this.toolTip1.SetToolTip(this.linkLabel_yazilimturk, "Go to WebSite");
            this.linkLabel_yazilimturk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_yazilimturk_LinkClicked);
            // 
            // groupBox_Method
            // 
            this.groupBox_Method.Controls.Add(this.label3);
            this.groupBox_Method.Controls.Add(this.radioButton_SmartCard);
            this.groupBox_Method.Controls.Add(this.radioButton_PFX);
            this.groupBox_Method.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox_Method.Location = new System.Drawing.Point(15, 78);
            this.groupBox_Method.Name = "groupBox_Method";
            this.groupBox_Method.Size = new System.Drawing.Size(953, 47);
            this.groupBox_Method.TabIndex = 8;
            this.groupBox_Method.TabStop = false;
            this.groupBox_Method.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(4, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Signing /Encryption Method";
            // 
            // radioButton_SmartCard
            // 
            this.radioButton_SmartCard.AutoSize = true;
            this.radioButton_SmartCard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_SmartCard.Location = new System.Drawing.Point(296, 15);
            this.radioButton_SmartCard.Name = "radioButton_SmartCard";
            this.radioButton_SmartCard.Size = new System.Drawing.Size(114, 25);
            this.radioButton_SmartCard.TabIndex = 1;
            this.radioButton_SmartCard.Text = "SmartCard";
            this.toolTip1.SetToolTip(this.radioButton_SmartCard, "Sign With SmartCard");
            this.radioButton_SmartCard.UseVisualStyleBackColor = true;
            this.radioButton_SmartCard.CheckedChanged += new System.EventHandler(this.radioButton_SmartCard_CheckedChanged);
            // 
            // radioButton_PFX
            // 
            this.radioButton_PFX.AutoSize = true;
            this.radioButton_PFX.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_PFX.Location = new System.Drawing.Point(236, 15);
            this.radioButton_PFX.Name = "radioButton_PFX";
            this.radioButton_PFX.Size = new System.Drawing.Size(54, 25);
            this.radioButton_PFX.TabIndex = 0;
            this.radioButton_PFX.Text = "PFX";
            this.toolTip1.SetToolTip(this.radioButton_PFX, "Sign With PFX");
            this.radioButton_PFX.UseVisualStyleBackColor = true;
            this.radioButton_PFX.CheckedChanged += new System.EventHandler(this.radioButton_PFX_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Settings,
            this.toolStripMenuItem_About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 25);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // toolStripMenuItem_Settings
            // 
            this.toolStripMenuItem_Settings.Name = "toolStripMenuItem_Settings";
            this.toolStripMenuItem_Settings.Size = new System.Drawing.Size(69, 21);
            this.toolStripMenuItem_Settings.Text = "Settings";
            this.toolStripMenuItem_Settings.Click += new System.EventHandler(this.toolStripMenuItem_Settings_Click);
            // 
            // toolStripMenuItem_About
            // 
            this.toolStripMenuItem_About.Name = "toolStripMenuItem_About";
            this.toolStripMenuItem_About.Size = new System.Drawing.Size(60, 21);
            this.toolStripMenuItem_About.Text = "About";
            this.toolStripMenuItem_About.Click += new System.EventHandler(this.toolStripMenuItem_About_Click);
            // 
            // pictureBox_MainFormLogo
            // 
            this.pictureBox_MainFormLogo.Image = global::CryptoWard.Properties.Resources.CryptoWard;
            this.pictureBox_MainFormLogo.Location = new System.Drawing.Point(8, 29);
            this.pictureBox_MainFormLogo.Name = "pictureBox_MainFormLogo";
            this.pictureBox_MainFormLogo.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_MainFormLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_MainFormLogo.TabIndex = 13;
            this.pictureBox_MainFormLogo.TabStop = false;
            this.pictureBox_MainFormLogo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.pictureBox_MainFormLogo);
            this.Controls.Add(this.groupBox_Method);
            this.Controls.Add(this.linkLabel_yazilimturk);
            this.Controls.Add(this.panel_MainForm);
            this.Controls.Add(this.label_MainFormSubTitle);
            this.Controls.Add(this.label_MainFormTitle);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CryptoWard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Method.ResumeLayout(false);
            this.groupBox_Method.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MainFormLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_MainFormTitle;
        private System.Windows.Forms.Label label_MainFormSubTitle;
        private System.Windows.Forms.Panel panel_MainForm;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.LinkLabel linkLabel_yazilimturk;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox_Method;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Settings;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_About;
        private System.Windows.Forms.RadioButton radioButton_SmartCard;
        private System.Windows.Forms.RadioButton radioButton_PFX;
        private System.Windows.Forms.PictureBox pictureBox_MainFormLogo;
        private System.Windows.Forms.Label label3;
    }
}

