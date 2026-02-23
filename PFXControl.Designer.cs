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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PFXControl));
            this.button_Select_PFX_File = new System.Windows.Forms.Button();
            this.textBox_PFX_Path = new System.Windows.Forms.TextBox();
            this.textBox_PFX_Pass = new System.Windows.Forms.TextBox();
            this.button_Select_File = new System.Windows.Forms.Button();
            this.textBox_File_Path = new System.Windows.Forms.TextBox();
            this.button_Sign = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Select_PFX_File
            // 
            this.button_Select_PFX_File.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Select_PFX_File.ImageIndex = 0;
            this.button_Select_PFX_File.ImageList = this.ımageList1;
            this.button_Select_PFX_File.Location = new System.Drawing.Point(747, 120);
            this.button_Select_PFX_File.Name = "button_Select_PFX_File";
            this.button_Select_PFX_File.Size = new System.Drawing.Size(200, 50);
            this.button_Select_PFX_File.TabIndex = 1;
            this.button_Select_PFX_File.Text = "Select PFX File";
            this.button_Select_PFX_File.UseVisualStyleBackColor = true;
            this.button_Select_PFX_File.Click += new System.EventHandler(this.button_Select_PFX_File_Click);
            // 
            // textBox_PFX_Path
            // 
            this.textBox_PFX_Path.Enabled = false;
            this.textBox_PFX_Path.Location = new System.Drawing.Point(102, 19);
            this.textBox_PFX_Path.Name = "textBox_PFX_Path";
            this.textBox_PFX_Path.Size = new System.Drawing.Size(845, 26);
            this.textBox_PFX_Path.TabIndex = 2;
            // 
            // textBox_PFX_Pass
            // 
            this.textBox_PFX_Pass.Location = new System.Drawing.Point(102, 51);
            this.textBox_PFX_Pass.Name = "textBox_PFX_Pass";
            this.textBox_PFX_Pass.PasswordChar = '*';
            this.textBox_PFX_Pass.Size = new System.Drawing.Size(344, 26);
            this.textBox_PFX_Pass.TabIndex = 3;
            // 
            // button_Select_File
            // 
            this.button_Select_File.Location = new System.Drawing.Point(132, 415);
            this.button_Select_File.Name = "button_Select_File";
            this.button_Select_File.Size = new System.Drawing.Size(128, 58);
            this.button_Select_File.TabIndex = 4;
            this.button_Select_File.Text = "Select File";
            this.button_Select_File.UseVisualStyleBackColor = true;
            this.button_Select_File.Click += new System.EventHandler(this.button_Select_File_Click);
            // 
            // textBox_File_Path
            // 
            this.textBox_File_Path.Location = new System.Drawing.Point(300, 415);
            this.textBox_File_Path.Name = "textBox_File_Path";
            this.textBox_File_Path.Size = new System.Drawing.Size(391, 26);
            this.textBox_File_Path.TabIndex = 5;
            // 
            // button_Sign
            // 
            this.button_Sign.Location = new System.Drawing.Point(822, 478);
            this.button_Sign.Name = "button_Sign";
            this.button_Sign.Size = new System.Drawing.Size(128, 58);
            this.button_Sign.TabIndex = 6;
            this.button_Sign.Text = "Sign";
            this.button_Sign.UseVisualStyleBackColor = true;
            this.button_Sign.Click += new System.EventHandler(this.button_Sign_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_PFX_Path);
            this.groupBox1.Controls.Add(this.textBox_PFX_Pass);
            this.groupBox1.Controls.Add(this.button_Select_PFX_File);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(953, 176);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PFX Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "PFX Pass";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(3, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(953, 191);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "PFXFile.fw.png");
            // 
            // PFXControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Sign);
            this.Controls.Add(this.textBox_File_Path);
            this.Controls.Add(this.button_Select_File);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PFXControl";
            this.Size = new System.Drawing.Size(959, 550);
            this.Load += new System.EventHandler(this.PFXControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
