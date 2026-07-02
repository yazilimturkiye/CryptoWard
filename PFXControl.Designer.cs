namespace CryptoWard
{
    partial class PFXControl
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
            this.button_Select_PFX_File = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox_PFX_Path = new System.Windows.Forms.TextBox();
            this.textBox_PFX_Pass = new System.Windows.Forms.TextBox();
            this.button_Select_File = new System.Windows.Forms.Button();
            this.textBox_File_Path = new System.Windows.Forms.TextBox();
            this.button_Sign = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_PFX_Pass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView_PFX = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox_SignatureFormat = new System.Windows.Forms.GroupBox();
            this.radioButton_PFXXAdES = new System.Windows.Forms.RadioButton();
            this.radioButton_PFXPAdES = new System.Windows.Forms.RadioButton();
            this.radioButton_PFXCAdES = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_SignatureType = new System.Windows.Forms.GroupBox();
            this.radioButton_PFXEnveloped = new System.Windows.Forms.RadioButton();
            this.radioButton_PFXAttached = new System.Windows.Forms.RadioButton();
            this.radioButton_PFXDetached = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox_HashAlgorithm = new System.Windows.Forms.GroupBox();
            this.radioButton_PFXSHA512 = new System.Windows.Forms.RadioButton();
            this.radioButton_PFXSHA384 = new System.Windows.Forms.RadioButton();
            this.radioButton_PFXSHA256 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox_SignatureFormat.SuspendLayout();
            this.groupBox_SignatureType.SuspendLayout();
            this.groupBox_HashAlgorithm.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Select_PFX_File
            // 
            this.button_Select_PFX_File.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Select_PFX_File.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Select_PFX_File.ImageList = this.ımageList1;
            this.button_Select_PFX_File.Location = new System.Drawing.Point(729, 16);
            this.button_Select_PFX_File.Name = "button_Select_PFX_File";
            this.button_Select_PFX_File.Size = new System.Drawing.Size(218, 30);
            this.button_Select_PFX_File.TabIndex = 1;
            this.button_Select_PFX_File.Text = "Select PFX File";
            this.button_Select_PFX_File.UseVisualStyleBackColor = true;
            this.button_Select_PFX_File.Click += new System.EventHandler(this.button_Select_PFX_File_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(40, 40);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // textBox_PFX_Path
            // 
            this.textBox_PFX_Path.Enabled = false;
            this.textBox_PFX_Path.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PFX_Path.Location = new System.Drawing.Point(166, 16);
            this.textBox_PFX_Path.Name = "textBox_PFX_Path";
            this.textBox_PFX_Path.ReadOnly = true;
            this.textBox_PFX_Path.Size = new System.Drawing.Size(557, 27);
            this.textBox_PFX_Path.TabIndex = 2;
            // 
            // textBox_PFX_Pass
            // 
            this.textBox_PFX_Pass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PFX_Pass.Location = new System.Drawing.Point(166, 49);
            this.textBox_PFX_Pass.Name = "textBox_PFX_Pass";
            this.textBox_PFX_Pass.PasswordChar = '*';
            this.textBox_PFX_Pass.Size = new System.Drawing.Size(557, 27);
            this.textBox_PFX_Pass.TabIndex = 3;
            // 
            // button_Select_File
            // 
            this.button_Select_File.Enabled = false;
            this.button_Select_File.Location = new System.Drawing.Point(729, 20);
            this.button_Select_File.Name = "button_Select_File";
            this.button_Select_File.Size = new System.Drawing.Size(218, 30);
            this.button_Select_File.TabIndex = 4;
            this.button_Select_File.Text = "Select File";
            this.button_Select_File.UseVisualStyleBackColor = true;
            this.button_Select_File.Click += new System.EventHandler(this.button_Select_File_Click);
            // 
            // textBox_File_Path
            // 
            this.textBox_File_Path.Enabled = false;
            this.textBox_File_Path.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_File_Path.Location = new System.Drawing.Point(166, 20);
            this.textBox_File_Path.Name = "textBox_File_Path";
            this.textBox_File_Path.ReadOnly = true;
            this.textBox_File_Path.Size = new System.Drawing.Size(557, 27);
            this.textBox_File_Path.TabIndex = 5;
            // 
            // button_Sign
            // 
            this.button_Sign.Enabled = false;
            this.button_Sign.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sign.Location = new System.Drawing.Point(738, 501);
            this.button_Sign.Name = "button_Sign";
            this.button_Sign.Size = new System.Drawing.Size(218, 46);
            this.button_Sign.TabIndex = 6;
            this.button_Sign.Text = "Sign with PFX";
            this.button_Sign.UseVisualStyleBackColor = true;
            this.button_Sign.Click += new System.EventHandler(this.button_Sign_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_PFX_Pass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_PFX_Path);
            this.groupBox1.Controls.Add(this.button_Select_PFX_File);
            this.groupBox1.Controls.Add(this.textBox_PFX_Pass);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(953, 88);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // button_PFX_Pass
            // 
            this.button_PFX_Pass.Enabled = false;
            this.button_PFX_Pass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PFX_Pass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_PFX_Pass.ImageList = this.ımageList1;
            this.button_PFX_Pass.Location = new System.Drawing.Point(729, 49);
            this.button_PFX_Pass.Name = "button_PFX_Pass";
            this.button_PFX_Pass.Size = new System.Drawing.Size(218, 30);
            this.button_PFX_Pass.TabIndex = 9;
            this.button_PFX_Pass.Text = "Load Certificate";
            this.button_PFX_Pass.UseVisualStyleBackColor = true;
            this.button_PFX_Pass.Click += new System.EventHandler(this.button_PFX_Pass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "PFX";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView_PFX);
            this.groupBox2.Location = new System.Drawing.Point(3, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(953, 165);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // listView_PFX
            // 
            this.listView_PFX.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_PFX.FullRowSelect = true;
            this.listView_PFX.GridLines = true;
            this.listView_PFX.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_PFX.HideSelection = false;
            this.listView_PFX.Location = new System.Drawing.Point(6, 15);
            this.listView_PFX.Name = "listView_PFX";
            this.listView_PFX.Size = new System.Drawing.Size(941, 144);
            this.listView_PFX.TabIndex = 1;
            this.listView_PFX.UseCompatibleStateImageBehavior = false;
            this.listView_PFX.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Property";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 720;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "File";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox_File_Path);
            this.groupBox3.Controls.Add(this.button_Select_File);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(953, 57);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // groupBox_SignatureFormat
            // 
            this.groupBox_SignatureFormat.Controls.Add(this.radioButton_PFXXAdES);
            this.groupBox_SignatureFormat.Controls.Add(this.radioButton_PFXPAdES);
            this.groupBox_SignatureFormat.Controls.Add(this.radioButton_PFXCAdES);
            this.groupBox_SignatureFormat.Controls.Add(this.label5);
            this.groupBox_SignatureFormat.Enabled = false;
            this.groupBox_SignatureFormat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_SignatureFormat.Location = new System.Drawing.Point(3, 312);
            this.groupBox_SignatureFormat.Name = "groupBox_SignatureFormat";
            this.groupBox_SignatureFormat.Size = new System.Drawing.Size(953, 51);
            this.groupBox_SignatureFormat.TabIndex = 11;
            this.groupBox_SignatureFormat.TabStop = false;
            // 
            // radioButton_PFXXAdES
            // 
            this.radioButton_PFXXAdES.AutoSize = true;
            this.radioButton_PFXXAdES.Location = new System.Drawing.Point(398, 18);
            this.radioButton_PFXXAdES.Name = "radioButton_PFXXAdES";
            this.radioButton_PFXXAdES.Size = new System.Drawing.Size(78, 25);
            this.radioButton_PFXXAdES.TabIndex = 10;
            this.radioButton_PFXXAdES.Text = "XAdES";
            this.radioButton_PFXXAdES.UseVisualStyleBackColor = true;
            // 
            // radioButton_PFXPAdES
            // 
            this.radioButton_PFXPAdES.AutoSize = true;
            this.radioButton_PFXPAdES.Location = new System.Drawing.Point(280, 18);
            this.radioButton_PFXPAdES.Name = "radioButton_PFXPAdES";
            this.radioButton_PFXPAdES.Size = new System.Drawing.Size(78, 25);
            this.radioButton_PFXPAdES.TabIndex = 9;
            this.radioButton_PFXPAdES.Text = "PAdES";
            this.radioButton_PFXPAdES.UseVisualStyleBackColor = true;
            // 
            // radioButton_PFXCAdES
            // 
            this.radioButton_PFXCAdES.AutoSize = true;
            this.radioButton_PFXCAdES.Checked = true;
            this.radioButton_PFXCAdES.Location = new System.Drawing.Point(166, 18);
            this.radioButton_PFXCAdES.Name = "radioButton_PFXCAdES";
            this.radioButton_PFXCAdES.Size = new System.Drawing.Size(82, 25);
            this.radioButton_PFXCAdES.TabIndex = 8;
            this.radioButton_PFXCAdES.TabStop = true;
            this.radioButton_PFXCAdES.Text = "CAdES";
            this.radioButton_PFXCAdES.UseVisualStyleBackColor = true;
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
            // groupBox_SignatureType
            // 
            this.groupBox_SignatureType.Controls.Add(this.radioButton_PFXEnveloped);
            this.groupBox_SignatureType.Controls.Add(this.radioButton_PFXAttached);
            this.groupBox_SignatureType.Controls.Add(this.radioButton_PFXDetached);
            this.groupBox_SignatureType.Controls.Add(this.label6);
            this.groupBox_SignatureType.Enabled = false;
            this.groupBox_SignatureType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_SignatureType.Location = new System.Drawing.Point(3, 363);
            this.groupBox_SignatureType.Name = "groupBox_SignatureType";
            this.groupBox_SignatureType.Size = new System.Drawing.Size(953, 51);
            this.groupBox_SignatureType.TabIndex = 12;
            this.groupBox_SignatureType.TabStop = false;
            // 
            // radioButton_PFXEnveloped
            // 
            this.radioButton_PFXEnveloped.AutoSize = true;
            this.radioButton_PFXEnveloped.Location = new System.Drawing.Point(398, 18);
            this.radioButton_PFXEnveloped.Name = "radioButton_PFXEnveloped";
            this.radioButton_PFXEnveloped.Size = new System.Drawing.Size(112, 25);
            this.radioButton_PFXEnveloped.TabIndex = 10;
            this.radioButton_PFXEnveloped.Text = "Enveloped";
            this.radioButton_PFXEnveloped.UseVisualStyleBackColor = true;
            // 
            // radioButton_PFXAttached
            // 
            this.radioButton_PFXAttached.AutoSize = true;
            this.radioButton_PFXAttached.Location = new System.Drawing.Point(280, 18);
            this.radioButton_PFXAttached.Name = "radioButton_PFXAttached";
            this.radioButton_PFXAttached.Size = new System.Drawing.Size(107, 25);
            this.radioButton_PFXAttached.TabIndex = 9;
            this.radioButton_PFXAttached.Text = "Attached";
            this.radioButton_PFXAttached.UseVisualStyleBackColor = true;
            // 
            // radioButton_PFXDetached
            // 
            this.radioButton_PFXDetached.AutoSize = true;
            this.radioButton_PFXDetached.Checked = true;
            this.radioButton_PFXDetached.Location = new System.Drawing.Point(166, 18);
            this.radioButton_PFXDetached.Name = "radioButton_PFXDetached";
            this.radioButton_PFXDetached.Size = new System.Drawing.Size(109, 25);
            this.radioButton_PFXDetached.TabIndex = 8;
            this.radioButton_PFXDetached.TabStop = true;
            this.radioButton_PFXDetached.Text = "Detached";
            this.radioButton_PFXDetached.UseVisualStyleBackColor = true;
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
            // groupBox_HashAlgorithm
            // 
            this.groupBox_HashAlgorithm.Controls.Add(this.radioButton_PFXSHA512);
            this.groupBox_HashAlgorithm.Controls.Add(this.radioButton_PFXSHA384);
            this.groupBox_HashAlgorithm.Controls.Add(this.radioButton_PFXSHA256);
            this.groupBox_HashAlgorithm.Controls.Add(this.label7);
            this.groupBox_HashAlgorithm.Enabled = false;
            this.groupBox_HashAlgorithm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_HashAlgorithm.Location = new System.Drawing.Point(3, 414);
            this.groupBox_HashAlgorithm.Name = "groupBox_HashAlgorithm";
            this.groupBox_HashAlgorithm.Size = new System.Drawing.Size(953, 51);
            this.groupBox_HashAlgorithm.TabIndex = 13;
            this.groupBox_HashAlgorithm.TabStop = false;
            // 
            // radioButton_PFXSHA512
            // 
            this.radioButton_PFXSHA512.AutoSize = true;
            this.radioButton_PFXSHA512.Location = new System.Drawing.Point(398, 17);
            this.radioButton_PFXSHA512.Name = "radioButton_PFXSHA512";
            this.radioButton_PFXSHA512.Size = new System.Drawing.Size(87, 25);
            this.radioButton_PFXSHA512.TabIndex = 10;
            this.radioButton_PFXSHA512.Text = "SHA512";
            this.radioButton_PFXSHA512.UseVisualStyleBackColor = true;
            // 
            // radioButton_PFXSHA384
            // 
            this.radioButton_PFXSHA384.AutoSize = true;
            this.radioButton_PFXSHA384.Location = new System.Drawing.Point(280, 17);
            this.radioButton_PFXSHA384.Name = "radioButton_PFXSHA384";
            this.radioButton_PFXSHA384.Size = new System.Drawing.Size(87, 25);
            this.radioButton_PFXSHA384.TabIndex = 9;
            this.radioButton_PFXSHA384.Text = "SHA384";
            this.radioButton_PFXSHA384.UseVisualStyleBackColor = true;
            // 
            // radioButton_PFXSHA256
            // 
            this.radioButton_PFXSHA256.AutoSize = true;
            this.radioButton_PFXSHA256.Checked = true;
            this.radioButton_PFXSHA256.Location = new System.Drawing.Point(166, 17);
            this.radioButton_PFXSHA256.Name = "radioButton_PFXSHA256";
            this.radioButton_PFXSHA256.Size = new System.Drawing.Size(87, 25);
            this.radioButton_PFXSHA256.TabIndex = 8;
            this.radioButton_PFXSHA256.TabStop = true;
            this.radioButton_PFXSHA256.Text = "SHA256";
            this.radioButton_PFXSHA256.UseVisualStyleBackColor = true;
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
            // PFXControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_HashAlgorithm);
            this.Controls.Add(this.groupBox_SignatureType);
            this.Controls.Add(this.groupBox_SignatureFormat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Sign);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PFXControl";
            this.Size = new System.Drawing.Size(959, 550);
            this.Load += new System.EventHandler(this.PFXControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox_SignatureFormat.ResumeLayout(false);
            this.groupBox_SignatureFormat.PerformLayout();
            this.groupBox_SignatureType.ResumeLayout(false);
            this.groupBox_SignatureType.PerformLayout();
            this.groupBox_HashAlgorithm.ResumeLayout(false);
            this.groupBox_HashAlgorithm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Select_PFX_File;
        private System.Windows.Forms.TextBox textBox_PFX_Path;
        private System.Windows.Forms.TextBox textBox_PFX_Pass;
        private System.Windows.Forms.Button button_Select_File;
        private System.Windows.Forms.TextBox textBox_File_Path;
        private System.Windows.Forms.Button button_Sign;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ListView listView_PFX;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button_PFX_Pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox_SignatureFormat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton_PFXXAdES;
        private System.Windows.Forms.RadioButton radioButton_PFXPAdES;
        private System.Windows.Forms.RadioButton radioButton_PFXCAdES;
        private System.Windows.Forms.GroupBox groupBox_SignatureType;
        private System.Windows.Forms.RadioButton radioButton_PFXEnveloped;
        private System.Windows.Forms.RadioButton radioButton_PFXAttached;
        private System.Windows.Forms.RadioButton radioButton_PFXDetached;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox_HashAlgorithm;
        private System.Windows.Forms.RadioButton radioButton_PFXSHA512;
        private System.Windows.Forms.RadioButton radioButton_PFXSHA384;
        private System.Windows.Forms.RadioButton radioButton_PFXSHA256;
        private System.Windows.Forms.Label label7;
    }
}
