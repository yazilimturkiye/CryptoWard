namespace CryptoWard
{
    partial class SCControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SCControl));
            this.groupBox_SCReader = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_SCPin = new System.Windows.Forms.TextBox();
            this.button_SCUnlock = new System.Windows.Forms.Button();
            this.comboBox_SCCertificates = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_SCRefreshReaders = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_SCReaders = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView_SCCertificateInfo = new System.Windows.Forms.ListView();
            this.SCProperty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SCValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox_SCDigest = new System.Windows.Forms.GroupBox();
            this.radioButton_SCSHA512 = new System.Windows.Forms.RadioButton();
            this.radioButton_SCSHA384 = new System.Windows.Forms.RadioButton();
            this.radioButton_SCSHA256 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox_SCSignatureType = new System.Windows.Forms.GroupBox();
            this.radioButton_SCEnveloped = new System.Windows.Forms.RadioButton();
            this.radioButton_SCAttached = new System.Windows.Forms.RadioButton();
            this.radioButton_SCDetached = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox_SCSignatureFormat = new System.Windows.Forms.GroupBox();
            this.radioButton_SCXAdES = new System.Windows.Forms.RadioButton();
            this.radioButton_SCPAdES = new System.Windows.Forms.RadioButton();
            this.radioButton_SCCAdES = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_SCFilePath = new System.Windows.Forms.TextBox();
            this.button_SCSelectFile = new System.Windows.Forms.Button();
            this.button_SCSign = new System.Windows.Forms.Button();
            this.toolTip_SCControl = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox_SCReader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_SCDigest.SuspendLayout();
            this.groupBox_SCSignatureType.SuspendLayout();
            this.groupBox_SCSignatureFormat.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_SCReader
            // 
            this.groupBox_SCReader.Controls.Add(this.label3);
            this.groupBox_SCReader.Controls.Add(this.textBox_SCPin);
            this.groupBox_SCReader.Controls.Add(this.button_SCUnlock);
            this.groupBox_SCReader.Controls.Add(this.comboBox_SCCertificates);
            this.groupBox_SCReader.Controls.Add(this.label1);
            this.groupBox_SCReader.Controls.Add(this.button_SCRefreshReaders);
            this.groupBox_SCReader.Controls.Add(this.label2);
            this.groupBox_SCReader.Controls.Add(this.comboBox_SCReaders);
            this.groupBox_SCReader.Location = new System.Drawing.Point(3, 1);
            this.groupBox_SCReader.Name = "groupBox_SCReader";
            this.groupBox_SCReader.Size = new System.Drawing.Size(953, 97);
            this.groupBox_SCReader.TabIndex = 0;
            this.groupBox_SCReader.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(318, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Certificates";
            // 
            // textBox_SCPin
            // 
            this.textBox_SCPin.Enabled = false;
            this.textBox_SCPin.Location = new System.Drawing.Point(173, 56);
            this.textBox_SCPin.Name = "textBox_SCPin";
            this.textBox_SCPin.PasswordChar = '*';
            this.textBox_SCPin.Size = new System.Drawing.Size(143, 27);
            this.textBox_SCPin.TabIndex = 2;
            this.toolTip_SCControl.SetToolTip(this.textBox_SCPin, "SmartCard PIN");
            // 
            // button_SCUnlock
            // 
            this.button_SCUnlock.Enabled = false;
            this.button_SCUnlock.Location = new System.Drawing.Point(729, 55);
            this.button_SCUnlock.Name = "button_SCUnlock";
            this.button_SCUnlock.Size = new System.Drawing.Size(218, 30);
            this.button_SCUnlock.TabIndex = 3;
            this.button_SCUnlock.Text = "Unlock Card";
            this.button_SCUnlock.UseVisualStyleBackColor = true;
            this.button_SCUnlock.Click += new System.EventHandler(this.button_SCUnlock_Click);
            // 
            // comboBox_SCCertificates
            // 
            this.comboBox_SCCertificates.Enabled = false;
            this.comboBox_SCCertificates.FormattingEnabled = true;
            this.comboBox_SCCertificates.Location = new System.Drawing.Point(424, 56);
            this.comboBox_SCCertificates.Name = "comboBox_SCCertificates";
            this.comboBox_SCCertificates.Size = new System.Drawing.Size(299, 29);
            this.comboBox_SCCertificates.TabIndex = 1;
            this.toolTip_SCControl.SetToolTip(this.comboBox_SCCertificates, "Dijital Certificates");
            this.comboBox_SCCertificates.SelectedIndexChanged += new System.EventHandler(this.comboBox_SCCertificates_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Smart Card Reader";
            // 
            // button_SCRefreshReaders
            // 
            this.button_SCRefreshReaders.Location = new System.Drawing.Point(729, 19);
            this.button_SCRefreshReaders.Name = "button_SCRefreshReaders";
            this.button_SCRefreshReaders.Size = new System.Drawing.Size(218, 30);
            this.button_SCRefreshReaders.TabIndex = 1;
            this.button_SCRefreshReaders.Text = "Refresh";
            this.button_SCRefreshReaders.UseVisualStyleBackColor = true;
            this.button_SCRefreshReaders.Click += new System.EventHandler(this.button_SCRefreshReaders_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "PIN";
            // 
            // comboBox_SCReaders
            // 
            this.comboBox_SCReaders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SCReaders.FormattingEnabled = true;
            this.comboBox_SCReaders.Location = new System.Drawing.Point(173, 21);
            this.comboBox_SCReaders.Name = "comboBox_SCReaders";
            this.comboBox_SCReaders.Size = new System.Drawing.Size(550, 29);
            this.comboBox_SCReaders.TabIndex = 0;
            this.toolTip_SCControl.SetToolTip(this.comboBox_SCReaders, "SmartCard Readers");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView_SCCertificateInfo);
            this.groupBox1.Location = new System.Drawing.Point(3, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(953, 171);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // listView_SCCertificateInfo
            // 
            this.listView_SCCertificateInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SCProperty,
            this.SCValue});
            this.listView_SCCertificateInfo.FullRowSelect = true;
            this.listView_SCCertificateInfo.GridLines = true;
            this.listView_SCCertificateInfo.HideSelection = false;
            this.listView_SCCertificateInfo.Location = new System.Drawing.Point(6, 17);
            this.listView_SCCertificateInfo.Name = "listView_SCCertificateInfo";
            this.listView_SCCertificateInfo.Size = new System.Drawing.Size(941, 144);
            this.listView_SCCertificateInfo.TabIndex = 0;
            this.listView_SCCertificateInfo.UseCompatibleStateImageBehavior = false;
            this.listView_SCCertificateInfo.View = System.Windows.Forms.View.Details;
            // 
            // SCProperty
            // 
            this.SCProperty.Text = "Property";
            this.SCProperty.Width = 200;
            // 
            // SCValue
            // 
            this.SCValue.Text = "Value";
            this.SCValue.Width = 720;
            // 
            // groupBox_SCDigest
            // 
            this.groupBox_SCDigest.Controls.Add(this.radioButton_SCSHA512);
            this.groupBox_SCDigest.Controls.Add(this.radioButton_SCSHA384);
            this.groupBox_SCDigest.Controls.Add(this.radioButton_SCSHA256);
            this.groupBox_SCDigest.Controls.Add(this.label7);
            this.groupBox_SCDigest.Enabled = false;
            this.groupBox_SCDigest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_SCDigest.Location = new System.Drawing.Point(3, 427);
            this.groupBox_SCDigest.Name = "groupBox_SCDigest";
            this.groupBox_SCDigest.Size = new System.Drawing.Size(953, 51);
            this.groupBox_SCDigest.TabIndex = 17;
            this.groupBox_SCDigest.TabStop = false;
            // 
            // radioButton_SCSHA512
            // 
            this.radioButton_SCSHA512.AutoSize = true;
            this.radioButton_SCSHA512.Location = new System.Drawing.Point(398, 17);
            this.radioButton_SCSHA512.Name = "radioButton_SCSHA512";
            this.radioButton_SCSHA512.Size = new System.Drawing.Size(87, 25);
            this.radioButton_SCSHA512.TabIndex = 10;
            this.radioButton_SCSHA512.TabStop = true;
            this.radioButton_SCSHA512.Text = "SHA512";
            this.toolTip_SCControl.SetToolTip(this.radioButton_SCSHA512, "SHA-512 is a cryptographic hash algorithm that produces a 512-bit message digest." +
        "\r\nIt offers the highest security level among the SHA-2 algorithms supported by t" +
        "his application.");
            this.radioButton_SCSHA512.UseVisualStyleBackColor = true;
            // 
            // radioButton_SCSHA384
            // 
            this.radioButton_SCSHA384.AutoSize = true;
            this.radioButton_SCSHA384.Location = new System.Drawing.Point(280, 17);
            this.radioButton_SCSHA384.Name = "radioButton_SCSHA384";
            this.radioButton_SCSHA384.Size = new System.Drawing.Size(87, 25);
            this.radioButton_SCSHA384.TabIndex = 9;
            this.radioButton_SCSHA384.TabStop = true;
            this.radioButton_SCSHA384.Text = "SHA384";
            this.toolTip_SCControl.SetToolTip(this.radioButton_SCSHA384, "SHA-384 is a member of the SHA-2 family that produces a 384-bit message digest.\r\n" +
        "It provides a higher security level than SHA-256 and is commonly used with large" +
        "r elliptic curve cryptography keys.");
            this.radioButton_SCSHA384.UseVisualStyleBackColor = true;
            // 
            // radioButton_SCSHA256
            // 
            this.radioButton_SCSHA256.AutoSize = true;
            this.radioButton_SCSHA256.Checked = true;
            this.radioButton_SCSHA256.Location = new System.Drawing.Point(166, 17);
            this.radioButton_SCSHA256.Name = "radioButton_SCSHA256";
            this.radioButton_SCSHA256.Size = new System.Drawing.Size(87, 25);
            this.radioButton_SCSHA256.TabIndex = 8;
            this.radioButton_SCSHA256.TabStop = true;
            this.radioButton_SCSHA256.Text = "SHA256";
            this.radioButton_SCSHA256.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Hash Algorithm";
            // 
            // groupBox_SCSignatureType
            // 
            this.groupBox_SCSignatureType.Controls.Add(this.radioButton_SCEnveloped);
            this.groupBox_SCSignatureType.Controls.Add(this.radioButton_SCAttached);
            this.groupBox_SCSignatureType.Controls.Add(this.radioButton_SCDetached);
            this.groupBox_SCSignatureType.Controls.Add(this.label6);
            this.groupBox_SCSignatureType.Enabled = false;
            this.groupBox_SCSignatureType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_SCSignatureType.Location = new System.Drawing.Point(3, 376);
            this.groupBox_SCSignatureType.Name = "groupBox_SCSignatureType";
            this.groupBox_SCSignatureType.Size = new System.Drawing.Size(953, 51);
            this.groupBox_SCSignatureType.TabIndex = 16;
            this.groupBox_SCSignatureType.TabStop = false;
            // 
            // radioButton_SCEnveloped
            // 
            this.radioButton_SCEnveloped.AutoSize = true;
            this.radioButton_SCEnveloped.Location = new System.Drawing.Point(398, 18);
            this.radioButton_SCEnveloped.Name = "radioButton_SCEnveloped";
            this.radioButton_SCEnveloped.Size = new System.Drawing.Size(112, 25);
            this.radioButton_SCEnveloped.TabIndex = 10;
            this.radioButton_SCEnveloped.TabStop = true;
            this.radioButton_SCEnveloped.Text = "Enveloped";
            this.toolTip_SCControl.SetToolTip(this.radioButton_SCEnveloped, "The original document is embedded inside the signed document together with the di" +
        "gital signature.\r\nThis format is commonly used for XML-based signature structure" +
        "s.");
            this.radioButton_SCEnveloped.UseVisualStyleBackColor = true;
            // 
            // radioButton_SCAttached
            // 
            this.radioButton_SCAttached.AutoSize = true;
            this.radioButton_SCAttached.Location = new System.Drawing.Point(280, 18);
            this.radioButton_SCAttached.Name = "radioButton_SCAttached";
            this.radioButton_SCAttached.Size = new System.Drawing.Size(107, 25);
            this.radioButton_SCAttached.TabIndex = 9;
            this.radioButton_SCAttached.TabStop = true;
            this.radioButton_SCAttached.Text = "Attached";
            this.toolTip_SCControl.SetToolTip(this.radioButton_SCAttached, "The digital signature is stored together with the original document in a single s" +
        "igned file.\r\nThe signed file contains both the original content and the digital " +
        "signature.");
            this.radioButton_SCAttached.UseVisualStyleBackColor = true;
            // 
            // radioButton_SCDetached
            // 
            this.radioButton_SCDetached.AutoSize = true;
            this.radioButton_SCDetached.Checked = true;
            this.radioButton_SCDetached.Location = new System.Drawing.Point(166, 18);
            this.radioButton_SCDetached.Name = "radioButton_SCDetached";
            this.radioButton_SCDetached.Size = new System.Drawing.Size(109, 25);
            this.radioButton_SCDetached.TabIndex = 8;
            this.radioButton_SCDetached.TabStop = true;
            this.radioButton_SCDetached.Text = "Detached";
            this.toolTip_SCControl.SetToolTip(this.radioButton_SCDetached, "The digital signature is stored in a separate signature file while the original d" +
        "ocument remains unchanged.\r\nBoth the original file and the signature file are re" +
        "quired during signature verification.");
            this.radioButton_SCDetached.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Signature Type";
            // 
            // groupBox_SCSignatureFormat
            // 
            this.groupBox_SCSignatureFormat.Controls.Add(this.radioButton_SCXAdES);
            this.groupBox_SCSignatureFormat.Controls.Add(this.radioButton_SCPAdES);
            this.groupBox_SCSignatureFormat.Controls.Add(this.radioButton_SCCAdES);
            this.groupBox_SCSignatureFormat.Controls.Add(this.label5);
            this.groupBox_SCSignatureFormat.Enabled = false;
            this.groupBox_SCSignatureFormat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_SCSignatureFormat.Location = new System.Drawing.Point(3, 325);
            this.groupBox_SCSignatureFormat.Name = "groupBox_SCSignatureFormat";
            this.groupBox_SCSignatureFormat.Size = new System.Drawing.Size(953, 51);
            this.groupBox_SCSignatureFormat.TabIndex = 15;
            this.groupBox_SCSignatureFormat.TabStop = false;
            // 
            // radioButton_SCXAdES
            // 
            this.radioButton_SCXAdES.AutoSize = true;
            this.radioButton_SCXAdES.Location = new System.Drawing.Point(398, 18);
            this.radioButton_SCXAdES.Name = "radioButton_SCXAdES";
            this.radioButton_SCXAdES.Size = new System.Drawing.Size(78, 25);
            this.radioButton_SCXAdES.TabIndex = 10;
            this.radioButton_SCXAdES.TabStop = true;
            this.radioButton_SCXAdES.Text = "XAdES";
            this.toolTip_SCControl.SetToolTip(this.radioButton_SCXAdES, "XAdES (XML Advanced Electronic Signatures)\r\n\r\nCreates an XML-based digital signat" +
        "ure.\r\nRecommended for XML documents and e-Government integrations.\r\n");
            this.radioButton_SCXAdES.UseVisualStyleBackColor = true;
            // 
            // radioButton_SCPAdES
            // 
            this.radioButton_SCPAdES.AutoSize = true;
            this.radioButton_SCPAdES.Location = new System.Drawing.Point(280, 18);
            this.radioButton_SCPAdES.Name = "radioButton_SCPAdES";
            this.radioButton_SCPAdES.Size = new System.Drawing.Size(78, 25);
            this.radioButton_SCPAdES.TabIndex = 9;
            this.radioButton_SCPAdES.TabStop = true;
            this.radioButton_SCPAdES.Text = "PAdES";
            this.toolTip_SCControl.SetToolTip(this.radioButton_SCPAdES, "PAdES (PDF Advanced Electronic Signatures)\r\n\r\nCreates a digital signature embedde" +
        "d directly into PDF documents.\r\nUse this format when signing PDF files.\r\n");
            this.radioButton_SCPAdES.UseVisualStyleBackColor = true;
            // 
            // radioButton_SCCAdES
            // 
            this.radioButton_SCCAdES.AutoSize = true;
            this.radioButton_SCCAdES.Checked = true;
            this.radioButton_SCCAdES.Location = new System.Drawing.Point(166, 18);
            this.radioButton_SCCAdES.Name = "radioButton_SCCAdES";
            this.radioButton_SCCAdES.Size = new System.Drawing.Size(82, 25);
            this.radioButton_SCCAdES.TabIndex = 8;
            this.radioButton_SCCAdES.TabStop = true;
            this.radioButton_SCCAdES.Text = "CAdES";
            this.toolTip_SCControl.SetToolTip(this.radioButton_SCCAdES, "CAdES (CMS Advanced Electronic Signatures)\r\n\r\nCreates a CMS/PKCS#7 based digital " +
        "signature for any type of file.\r\nRecommended for general-purpose electronic sign" +
        "ature operations.");
            this.radioButton_SCCAdES.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Signature Format";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox_SCFilePath);
            this.groupBox3.Controls.Add(this.button_SCSelectFile);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(953, 57);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "File";
            // 
            // textBox_SCFilePath
            // 
            this.textBox_SCFilePath.Enabled = false;
            this.textBox_SCFilePath.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SCFilePath.Location = new System.Drawing.Point(166, 20);
            this.textBox_SCFilePath.Name = "textBox_SCFilePath";
            this.textBox_SCFilePath.ReadOnly = true;
            this.textBox_SCFilePath.Size = new System.Drawing.Size(557, 27);
            this.textBox_SCFilePath.TabIndex = 5;
            this.toolTip_SCControl.SetToolTip(this.textBox_SCFilePath, "File Path");
            // 
            // button_SCSelectFile
            // 
            this.button_SCSelectFile.Enabled = false;
            this.button_SCSelectFile.Location = new System.Drawing.Point(729, 20);
            this.button_SCSelectFile.Name = "button_SCSelectFile";
            this.button_SCSelectFile.Size = new System.Drawing.Size(218, 30);
            this.button_SCSelectFile.TabIndex = 4;
            this.button_SCSelectFile.Text = "Select File";
            this.button_SCSelectFile.UseVisualStyleBackColor = true;
            this.button_SCSelectFile.Click += new System.EventHandler(this.button_SCSelectFile_Click);
            // 
            // button_SCSign
            // 
            this.button_SCSign.Enabled = false;
            this.button_SCSign.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SCSign.Location = new System.Drawing.Point(738, 501);
            this.button_SCSign.Name = "button_SCSign";
            this.button_SCSign.Size = new System.Drawing.Size(218, 46);
            this.button_SCSign.TabIndex = 18;
            this.button_SCSign.Text = "Sign with SmartCard";
            this.button_SCSign.UseVisualStyleBackColor = true;
            this.button_SCSign.Click += new System.EventHandler(this.button_SCSign_Click);
            // 
            // SCControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_SCSign);
            this.Controls.Add(this.groupBox_SCDigest);
            this.Controls.Add(this.groupBox_SCSignatureType);
            this.Controls.Add(this.groupBox_SCSignatureFormat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_SCReader);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SCControl";
            this.Size = new System.Drawing.Size(959, 550);
            this.toolTip_SCControl.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.SCControl_Load);
            this.groupBox_SCReader.ResumeLayout(false);
            this.groupBox_SCReader.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox_SCDigest.ResumeLayout(false);
            this.groupBox_SCDigest.PerformLayout();
            this.groupBox_SCSignatureType.ResumeLayout(false);
            this.groupBox_SCSignatureType.PerformLayout();
            this.groupBox_SCSignatureFormat.ResumeLayout(false);
            this.groupBox_SCSignatureFormat.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_SCReader;
        private System.Windows.Forms.Button button_SCRefreshReaders;
        private System.Windows.Forms.ComboBox comboBox_SCReaders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_SCPin;
        private System.Windows.Forms.Button button_SCUnlock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_SCCertificates;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView_SCCertificateInfo;
        private System.Windows.Forms.ColumnHeader SCProperty;
        private System.Windows.Forms.ColumnHeader SCValue;
        private System.Windows.Forms.GroupBox groupBox_SCDigest;
        private System.Windows.Forms.RadioButton radioButton_SCSHA512;
        private System.Windows.Forms.RadioButton radioButton_SCSHA384;
        private System.Windows.Forms.RadioButton radioButton_SCSHA256;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox_SCSignatureType;
        private System.Windows.Forms.RadioButton radioButton_SCEnveloped;
        private System.Windows.Forms.RadioButton radioButton_SCAttached;
        private System.Windows.Forms.RadioButton radioButton_SCDetached;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox_SCSignatureFormat;
        private System.Windows.Forms.RadioButton radioButton_SCXAdES;
        private System.Windows.Forms.RadioButton radioButton_SCPAdES;
        private System.Windows.Forms.RadioButton radioButton_SCCAdES;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_SCFilePath;
        private System.Windows.Forms.Button button_SCSelectFile;
        private System.Windows.Forms.Button button_SCSign;
        private System.Windows.Forms.ToolTip toolTip_SCControl;
    }
}
