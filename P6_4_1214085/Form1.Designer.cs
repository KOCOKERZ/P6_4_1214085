namespace P6_4_1214085
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
            this.lbNama = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbNPM = new System.Windows.Forms.TextBox();
            this.lbNPM = new System.Windows.Forms.Label();
            this.tbAgama = new System.Windows.Forms.TextBox();
            this.lbAgama = new System.Windows.Forms.Label();
            this.tbHobi = new System.Windows.Forms.TextBox();
            this.lbHobi = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbUmur = new System.Windows.Forms.TextBox();
            this.lbUmur = new System.Windows.Forms.Label();
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtAngka1 = new System.Windows.Forms.TextBox();
            this.lbAngka1 = new System.Windows.Forms.Label();
            this.txtAngka2 = new System.Windows.Forms.TextBox();
            this.lbAngka2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btTampilkan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Location = new System.Drawing.Point(202, 93);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(51, 20);
            this.lbNama.TabIndex = 0;
            this.lbNama.Text = "Nama";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(367, 87);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(229, 26);
            this.tbNama.TabIndex = 1;
            this.tbNama.Leave += new System.EventHandler(this.tbNama_Leave);
            // 
            // tbNPM
            // 
            this.tbNPM.Location = new System.Drawing.Point(367, 133);
            this.tbNPM.Name = "tbNPM";
            this.tbNPM.Size = new System.Drawing.Size(229, 26);
            this.tbNPM.TabIndex = 3;
            this.tbNPM.Leave += new System.EventHandler(this.tbNPM_Leave);
            // 
            // lbNPM
            // 
            this.lbNPM.AutoSize = true;
            this.lbNPM.Location = new System.Drawing.Point(202, 139);
            this.lbNPM.Name = "lbNPM";
            this.lbNPM.Size = new System.Drawing.Size(43, 20);
            this.lbNPM.TabIndex = 2;
            this.lbNPM.Text = "NPM";
            // 
            // tbAgama
            // 
            this.tbAgama.Location = new System.Drawing.Point(367, 179);
            this.tbAgama.Name = "tbAgama";
            this.tbAgama.Size = new System.Drawing.Size(229, 26);
            this.tbAgama.TabIndex = 5;
            this.tbAgama.Leave += new System.EventHandler(this.tbAgama_Leave);
            // 
            // lbAgama
            // 
            this.lbAgama.AutoSize = true;
            this.lbAgama.Location = new System.Drawing.Point(202, 185);
            this.lbAgama.Name = "lbAgama";
            this.lbAgama.Size = new System.Drawing.Size(60, 20);
            this.lbAgama.TabIndex = 4;
            this.lbAgama.Text = "Agama";
            // 
            // tbHobi
            // 
            this.tbHobi.Location = new System.Drawing.Point(367, 225);
            this.tbHobi.Name = "tbHobi";
            this.tbHobi.Size = new System.Drawing.Size(229, 26);
            this.tbHobi.TabIndex = 7;
            this.tbHobi.Leave += new System.EventHandler(this.tbHobi_Leave);
            // 
            // lbHobi
            // 
            this.lbHobi.AutoSize = true;
            this.lbHobi.Location = new System.Drawing.Point(202, 231);
            this.lbHobi.Name = "lbHobi";
            this.lbHobi.Size = new System.Drawing.Size(42, 20);
            this.lbHobi.TabIndex = 6;
            this.lbHobi.Text = "Hobi";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(367, 271);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(229, 26);
            this.tbEmail.TabIndex = 9;
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(202, 277);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(48, 20);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "Email";
            // 
            // tbUmur
            // 
            this.tbUmur.Location = new System.Drawing.Point(367, 317);
            this.tbUmur.Name = "tbUmur";
            this.tbUmur.Size = new System.Drawing.Size(229, 26);
            this.tbUmur.TabIndex = 11;
            this.tbUmur.Leave += new System.EventHandler(this.tbUmur_Leave);
            // 
            // lbUmur
            // 
            this.lbUmur.AutoSize = true;
            this.lbUmur.Location = new System.Drawing.Point(202, 323);
            this.lbUmur.Name = "lbUmur";
            this.lbUmur.Size = new System.Drawing.Size(48, 20);
            this.lbUmur.TabIndex = 10;
            this.lbUmur.Text = "Umur";
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // txtAngka1
            // 
            this.txtAngka1.Location = new System.Drawing.Point(367, 403);
            this.txtAngka1.Name = "txtAngka1";
            this.txtAngka1.Size = new System.Drawing.Size(229, 26);
            this.txtAngka1.TabIndex = 13;
            this.txtAngka1.Leave += new System.EventHandler(this.txtAngka1_Leave);
            // 
            // lbAngka1
            // 
            this.lbAngka1.AutoSize = true;
            this.lbAngka1.Location = new System.Drawing.Point(202, 409);
            this.lbAngka1.Name = "lbAngka1";
            this.lbAngka1.Size = new System.Drawing.Size(68, 20);
            this.lbAngka1.TabIndex = 12;
            this.lbAngka1.Text = "Angka 1";
            // 
            // txtAngka2
            // 
            this.txtAngka2.Location = new System.Drawing.Point(367, 454);
            this.txtAngka2.Name = "txtAngka2";
            this.txtAngka2.Size = new System.Drawing.Size(229, 26);
            this.txtAngka2.TabIndex = 15;
            this.txtAngka2.Leave += new System.EventHandler(this.txtAngka2_Leave);
            // 
            // lbAngka2
            // 
            this.lbAngka2.AutoSize = true;
            this.lbAngka2.Location = new System.Drawing.Point(202, 460);
            this.lbAngka2.Name = "lbAngka2";
            this.lbAngka2.Size = new System.Drawing.Size(68, 20);
            this.lbAngka2.TabIndex = 14;
            this.lbAngka2.Text = "Angka 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(328, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Angka 1 > Angka 2";
            // 
            // btTampilkan
            // 
            this.btTampilkan.AutoSize = true;
            this.btTampilkan.Location = new System.Drawing.Point(434, 516);
            this.btTampilkan.Name = "btTampilkan";
            this.btTampilkan.Size = new System.Drawing.Size(91, 30);
            this.btTampilkan.TabIndex = 17;
            this.btTampilkan.Text = "Tampilkan";
            this.btTampilkan.UseVisualStyleBackColor = true;
            this.btTampilkan.Click += new System.EventHandler(this.btTampilkan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.btTampilkan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAngka2);
            this.Controls.Add(this.lbAngka2);
            this.Controls.Add(this.txtAngka1);
            this.Controls.Add(this.lbAngka1);
            this.Controls.Add(this.tbUmur);
            this.Controls.Add(this.lbUmur);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbHobi);
            this.Controls.Add(this.lbHobi);
            this.Controls.Add(this.tbAgama);
            this.Controls.Add(this.lbAgama);
            this.Controls.Add(this.tbNPM);
            this.Controls.Add(this.lbNPM);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.lbNama);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbNPM;
        private System.Windows.Forms.Label lbNPM;
        private System.Windows.Forms.TextBox tbAgama;
        private System.Windows.Forms.Label lbAgama;
        private System.Windows.Forms.TextBox tbHobi;
        private System.Windows.Forms.Label lbHobi;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbUmur;
        private System.Windows.Forms.Label lbUmur;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAngka2;
        private System.Windows.Forms.Label lbAngka2;
        private System.Windows.Forms.TextBox txtAngka1;
        private System.Windows.Forms.Label lbAngka1;
        private System.Windows.Forms.Button btTampilkan;
    }
}

