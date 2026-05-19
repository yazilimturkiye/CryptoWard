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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel_MainForm = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox_Method = new System.Windows.Forms.GroupBox();
            this.radioButton_SmartCard = new System.Windows.Forms.RadioButton();
            this.radioButton_PFX = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStripMenuItem_PFX = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_SC = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_Method.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(56, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "CryptoWard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(58, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digital Signing Tool\r\n";
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
            this.panel_MainForm.Size = new System.Drawing.Size(959, 521);
            this.panel_MainForm.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(836, 648);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(140, 20);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "yazilimturkiye.com";
            // 
            // groupBox_Method
            // 
            this.groupBox_Method.Controls.Add(this.label3);
            this.groupBox_Method.Controls.Add(this.radioButton_SmartCard);
            this.groupBox_Method.Controls.Add(this.radioButton_PFX);
            this.groupBox_Method.Enabled = false;
            this.groupBox_Method.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox_Method.Location = new System.Drawing.Point(15, 78);
            this.groupBox_Method.Name = "groupBox_Method";
            this.groupBox_Method.Size = new System.Drawing.Size(953, 47);
            this.groupBox_Method.TabIndex = 8;
            this.groupBox_Method.TabStop = false;
            // 
            // radioButton_SmartCard
            // 
            this.radioButton_SmartCard.AutoSize = true;
            this.radioButton_SmartCard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_SmartCard.Location = new System.Drawing.Point(356, 15);
            this.radioButton_SmartCard.Name = "radioButton_SmartCard";
            this.radioButton_SmartCard.Size = new System.Drawing.Size(114, 25);
            this.radioButton_SmartCard.TabIndex = 1;
            this.radioButton_SmartCard.Text = "SmartCard";
            this.radioButton_SmartCard.UseVisualStyleBackColor = true;
            // 
            // radioButton_PFX
            // 
            this.radioButton_PFX.AutoSize = true;
            this.radioButton_PFX.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_PFX.Location = new System.Drawing.Point(296, 15);
            this.radioButton_PFX.Name = "radioButton_PFX";
            this.radioButton_PFX.Size = new System.Drawing.Size(54, 25);
            this.radioButton_PFX.TabIndex = 0;
            this.radioButton_PFX.Text = "PFX";
            this.radioButton_PFX.UseVisualStyleBackColor = true;
            this.radioButton_PFX.CheckedChanged += new System.EventHandler(this.radioButton_PFX_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Tools,
            this.toolStripMenuItem_Settings,
            this.toolStripMenuItem_About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 25);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem_Tools
            // 
            this.toolStripMenuItem_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_PFX,
            this.toolStripMenuItem_SC});
            this.toolStripMenuItem_Tools.Name = "toolStripMenuItem_Tools";
            this.toolStripMenuItem_Tools.Size = new System.Drawing.Size(51, 21);
            this.toolStripMenuItem_Tools.Text = "Tools";
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
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(918, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // toolStripMenuItem_PFX
            // 
            this.toolStripMenuItem_PFX.Name = "toolStripMenuItem_PFX";
            this.toolStripMenuItem_PFX.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItem_PFX.Text = "PFX";
            // 
            // toolStripMenuItem_SC
            // 
            this.toolStripMenuItem_SC.Name = "toolStripMenuItem_SC";
            this.toolStripMenuItem_SC.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItem_SC.Text = "SmartCards";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(4, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select Signing /Encryption Method";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::CryptoWard.Properties.Resources.CryptoWard;
            this.pictureBox1.Location = new System.Drawing.Point(6, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 671);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox_Method);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel_MainForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_MainForm;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox_Method;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Tools;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Settings;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_About;
        private System.Windows.Forms.RadioButton radioButton_SmartCard;
        private System.Windows.Forms.RadioButton radioButton_PFX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_PFX;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_SC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}

