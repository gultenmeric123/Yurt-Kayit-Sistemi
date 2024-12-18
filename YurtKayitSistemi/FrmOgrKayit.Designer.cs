namespace YurtKayitSistemi
{
    partial class FrmOgrKayit
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
			this.label1 = new System.Windows.Forms.Label();
			this.TxtOgrAd = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtOgrSoyad = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TxtMail = new System.Windows.Forms.TextBox();
			this.MSKTC = new System.Windows.Forms.MaskedTextBox();
			this.MSKOgrTelefon = new System.Windows.Forms.MaskedTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.MskDogumTarihi = new System.Windows.Forms.MaskedTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.CmbBolum = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.CmbOdaNo = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.TxtVeliAdSoyad = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.mskVeliTelefon = new System.Windows.Forms.MaskedTextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.richAdres = new System.Windows.Forms.RichTextBox();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(46, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Öğrenci Ad:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// TxtOgrAd
			// 
			this.TxtOgrAd.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.TxtOgrAd.Location = new System.Drawing.Point(183, 9);
			this.TxtOgrAd.Name = "TxtOgrAd";
			this.TxtOgrAd.Size = new System.Drawing.Size(180, 37);
			this.TxtOgrAd.TabIndex = 1;
			this.TxtOgrAd.TextChanged += new System.EventHandler(this.TxtOgrAd_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(22, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(162, 30);
			this.label2.TabIndex = 2;
			this.label2.Text = "Öğrenci Soyad:";
			// 
			// TxtOgrSoyad
			// 
			this.TxtOgrSoyad.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.TxtOgrSoyad.Location = new System.Drawing.Point(183, 41);
			this.TxtOgrSoyad.Name = "TxtOgrSoyad";
			this.TxtOgrSoyad.Size = new System.Drawing.Size(180, 37);
			this.TxtOgrSoyad.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(113, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 30);
			this.label3.TabIndex = 4;
			this.label3.Text = "TC:";
			// 
			// TxtMail
			// 
			this.TxtMail.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.TxtMail.Location = new System.Drawing.Point(183, 229);
			this.TxtMail.Name = "TxtMail";
			this.TxtMail.Size = new System.Drawing.Size(180, 37);
			this.TxtMail.TabIndex = 5;
			// 
			// MSKTC
			// 
			this.MSKTC.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.MSKTC.Location = new System.Drawing.Point(183, 77);
			this.MSKTC.Mask = "00000000000";
			this.MSKTC.Name = "MSKTC";
			this.MSKTC.Size = new System.Drawing.Size(180, 37);
			this.MSKTC.TabIndex = 6;
			this.MSKTC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
			// 
			// MSKOgrTelefon
			// 
			this.MSKOgrTelefon.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.MSKOgrTelefon.Location = new System.Drawing.Point(183, 116);
			this.MSKOgrTelefon.Mask = "(999) 000-0000";
			this.MSKOgrTelefon.Name = "MSKOgrTelefon";
			this.MSKOgrTelefon.Size = new System.Drawing.Size(180, 37);
			this.MSKOgrTelefon.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(77, 123);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 30);
			this.label4.TabIndex = 8;
			this.label4.Text = "Telefon:";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(16, 155);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(165, 30);
			this.label5.TabIndex = 9;
			this.label5.Text = "Doğum Tarihi:";
			// 
			// MskDogumTarihi
			// 
			this.MskDogumTarihi.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.MskDogumTarihi.Location = new System.Drawing.Point(183, 152);
			this.MskDogumTarihi.Mask = "00/00/0000";
			this.MskDogumTarihi.Name = "MskDogumTarihi";
			this.MskDogumTarihi.Size = new System.Drawing.Size(180, 37);
			this.MskDogumTarihi.TabIndex = 10;
			this.MskDogumTarihi.ValidatingType = typeof(System.DateTime);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(14, 195);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(168, 30);
			this.label6.TabIndex = 11;
			this.label6.Text = "Öğrenci Bölüm:";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// CmbBolum
			// 
			this.CmbBolum.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.CmbBolum.FormattingEnabled = true;
			this.CmbBolum.Location = new System.Drawing.Point(183, 192);
			this.CmbBolum.Name = "CmbBolum";
			this.CmbBolum.Size = new System.Drawing.Size(180, 38);
			this.CmbBolum.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(93, 229);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(70, 30);
			this.label7.TabIndex = 13;
			this.label7.Text = "Mail:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.Location = new System.Drawing.Point(73, 266);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(93, 30);
			this.label8.TabIndex = 14;
			this.label8.Text = "Oda No:";
			// 
			// CmbOdaNo
			// 
			this.CmbOdaNo.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.CmbOdaNo.FormattingEnabled = true;
			this.CmbOdaNo.Location = new System.Drawing.Point(185, 266);
			this.CmbOdaNo.Name = "CmbOdaNo";
			this.CmbOdaNo.Size = new System.Drawing.Size(178, 38);
			this.CmbOdaNo.TabIndex = 15;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label9.Location = new System.Drawing.Point(18, 303);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(161, 30);
			this.label9.TabIndex = 16;
			this.label9.Text = "Veli Ad Soyad:";
			this.label9.Click += new System.EventHandler(this.label9_Click);
			// 
			// TxtVeliAdSoyad
			// 
			this.TxtVeliAdSoyad.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.TxtVeliAdSoyad.Location = new System.Drawing.Point(185, 303);
			this.TxtVeliAdSoyad.Name = "TxtVeliAdSoyad";
			this.TxtVeliAdSoyad.Size = new System.Drawing.Size(178, 37);
			this.TxtVeliAdSoyad.TabIndex = 17;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label10.Location = new System.Drawing.Point(38, 340);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(137, 30);
			this.label10.TabIndex = 18;
			this.label10.Text = "Veli Telefon:";
			// 
			// mskVeliTelefon
			// 
			this.mskVeliTelefon.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.mskVeliTelefon.Location = new System.Drawing.Point(183, 337);
			this.mskVeliTelefon.Mask = "(999) 000-0000";
			this.mskVeliTelefon.Name = "mskVeliTelefon";
			this.mskVeliTelefon.Size = new System.Drawing.Size(180, 37);
			this.mskVeliTelefon.TabIndex = 19;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label11.Location = new System.Drawing.Point(86, 370);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(74, 30);
			this.label11.TabIndex = 20;
			this.label11.Text = "Adres:";
			// 
			// richAdres
			// 
			this.richAdres.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richAdres.Location = new System.Drawing.Point(152, 380);
			this.richAdres.Name = "richAdres";
			this.richAdres.Size = new System.Drawing.Size(242, 138);
			this.richAdres.TabIndex = 21;
			this.richAdres.Text = "";
			// 
			// btnKaydet
			// 
			this.btnKaydet.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKaydet.Location = new System.Drawing.Point(208, 524);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(137, 34);
			this.btnKaydet.TabIndex = 22;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(75, 413);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(54, 17);
			this.label12.TabIndex = 23;
			this.label12.Text = "label12";
			// 
			// FrmOgrKayit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Linen;
			this.ClientSize = new System.Drawing.Size(446, 584);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.richAdres);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.mskVeliTelefon);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.TxtVeliAdSoyad);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.CmbOdaNo);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.CmbBolum);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.MskDogumTarihi);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.MSKOgrTelefon);
			this.Controls.Add(this.MSKTC);
			this.Controls.Add(this.TxtMail);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.TxtOgrSoyad);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TxtOgrAd);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.Name = "FrmOgrKayit";
			this.Text = "Öğrenci Kayıt";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtOgrAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOgrSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.MaskedTextBox MSKTC;
        private System.Windows.Forms.MaskedTextBox MSKOgrTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox MskDogumTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbBolum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbOdaNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtVeliAdSoyad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskVeliTelefon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richAdres;
        private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.Label label12;
	}
}

