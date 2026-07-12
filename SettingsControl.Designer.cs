namespace CryptoWard
{
    partial class SettingsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsControl));
            this.textbox_LicensePath = new System.Windows.Forms.TextBox();
            this.button_LoadLicense = new System.Windows.Forms.Button();
            this.button_SelectLicense = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label_APIState = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_APILisanceID = new System.Windows.Forms.TextBox();
            this.textBox_APILisanceDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_Next = new System.Windows.Forms.Button();
            this.toolTip_SettingsControl = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbox_LicensePath
            // 
            this.textbox_LicensePath.Location = new System.Drawing.Point(183, 20);
            this.textbox_LicensePath.Margin = new System.Windows.Forms.Padding(5);
            this.textbox_LicensePath.Name = "textbox_LicensePath";
            this.textbox_LicensePath.ReadOnly = true;
            this.textbox_LicensePath.Size = new System.Drawing.Size(534, 27);
            this.textbox_LicensePath.TabIndex = 5;
            this.textbox_LicensePath.TabStop = false;
            this.toolTip_SettingsControl.SetToolTip(this.textbox_LicensePath, "Lisance Path");
            // 
            // button_LoadLicense
            // 
            this.button_LoadLicense.Enabled = false;
            this.button_LoadLicense.Location = new System.Drawing.Point(727, 54);
            this.button_LoadLicense.Margin = new System.Windows.Forms.Padding(5);
            this.button_LoadLicense.Name = "button_LoadLicense";
            this.button_LoadLicense.Size = new System.Drawing.Size(218, 62);
            this.button_LoadLicense.TabIndex = 1;
            this.button_LoadLicense.Text = "Initialize MA3 API";
            this.button_LoadLicense.UseVisualStyleBackColor = true;
            this.button_LoadLicense.Click += new System.EventHandler(this.button_LoadLicense_Click);
            // 
            // button_SelectLicense
            // 
            this.button_SelectLicense.Location = new System.Drawing.Point(727, 20);
            this.button_SelectLicense.Margin = new System.Windows.Forms.Padding(5);
            this.button_SelectLicense.Name = "button_SelectLicense";
            this.button_SelectLicense.Size = new System.Drawing.Size(218, 30);
            this.button_SelectLicense.TabIndex = 0;
            this.button_SelectLicense.Text = "Select Lisance";
            this.button_SelectLicense.UseVisualStyleBackColor = true;
            this.button_SelectLicense.Click += new System.EventHandler(this.button_SelectLicense_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label_APIState);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(953, 154);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Silver;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ForeColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel1.Location = new System.Drawing.Point(5, 122);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(180, 21);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "yazilim.kamusm.gov.tr";
            this.toolTip_SettingsControl.SetToolTip(this.linkLabel1, "Go to WebSite");
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label_APIState
            // 
            this.label_APIState.AutoSize = true;
            this.label_APIState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_APIState.ForeColor = System.Drawing.Color.Crimson;
            this.label_APIState.Location = new System.Drawing.Point(468, 16);
            this.label_APIState.Name = "label_APIState";
            this.label_APIState.Size = new System.Drawing.Size(116, 21);
            this.label_APIState.TabIndex = 8;
            this.label_APIState.Text = "Not Initialized";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(4, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(905, 105);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "MA3 API Lisance";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_APILisanceID);
            this.groupBox2.Controls.Add(this.textBox_APILisanceDate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button_SelectLicense);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textbox_LicensePath);
            this.groupBox2.Controls.Add(this.button_LoadLicense);
            this.groupBox2.Location = new System.Drawing.Point(3, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(953, 128);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID";
            // 
            // textBox_APILisanceID
            // 
            this.textBox_APILisanceID.Location = new System.Drawing.Point(183, 89);
            this.textBox_APILisanceID.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_APILisanceID.Name = "textBox_APILisanceID";
            this.textBox_APILisanceID.ReadOnly = true;
            this.textBox_APILisanceID.Size = new System.Drawing.Size(534, 27);
            this.textBox_APILisanceID.TabIndex = 7;
            this.textBox_APILisanceID.TabStop = false;
            this.toolTip_SettingsControl.SetToolTip(this.textBox_APILisanceID, "Lisance ID");
            // 
            // textBox_APILisanceDate
            // 
            this.textBox_APILisanceDate.Location = new System.Drawing.Point(183, 54);
            this.textBox_APILisanceDate.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_APILisanceDate.Name = "textBox_APILisanceDate";
            this.textBox_APILisanceDate.ReadOnly = true;
            this.textBox_APILisanceDate.Size = new System.Drawing.Size(534, 27);
            this.textBox_APILisanceDate.TabIndex = 6;
            this.textBox_APILisanceDate.TabStop = false;
            this.toolTip_SettingsControl.SetToolTip(this.textBox_APILisanceDate, "Expiration Date");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Expiration";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_Next);
            this.groupBox3.Location = new System.Drawing.Point(3, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(953, 263);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // button_Next
            // 
            this.button_Next.Enabled = false;
            this.button_Next.Location = new System.Drawing.Point(727, 209);
            this.button_Next.Margin = new System.Windows.Forms.Padding(5);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(218, 46);
            this.button_Next.TabIndex = 2;
            this.button_Next.Text = "OK";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(959, 550);
            this.Load += new System.EventHandler(this.SettingsControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_LicensePath;
        private System.Windows.Forms.Button button_LoadLicense;
        private System.Windows.Forms.Button button_SelectLicense;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_APILisanceID;
        private System.Windows.Forms.TextBox textBox_APILisanceDate;
        private System.Windows.Forms.Label label_APIState;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolTip toolTip_SettingsControl;
    }
}
