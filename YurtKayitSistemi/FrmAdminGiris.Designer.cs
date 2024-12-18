namespace YurtKayitSistemi
{
	partial class FrmAdminGiris
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
			this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
			this.button1 = new System.Windows.Forms.Button();
			this.TxtSifre = new System.Windows.Forms.TextBox();
			this.TxtKullaniciAd = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.Location = new System.Drawing.Point(321, 278);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(172, 38);
			this.button1.TabIndex = 1;
			this.button1.Text = "Giriş Yap";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// TxtSifre
			// 
			this.TxtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.TxtSifre.Location = new System.Drawing.Point(178, 152);
			this.TxtSifre.Name = "TxtSifre";
			this.TxtSifre.Size = new System.Drawing.Size(315, 26);
			this.TxtSifre.TabIndex = 2;
			this.TxtSifre.UseSystemPasswordChar = true;
			this.TxtSifre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// TxtKullaniciAd
			// 
			this.TxtKullaniciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.TxtKullaniciAd.Location = new System.Drawing.Point(178, 104);
			this.TxtKullaniciAd.Name = "TxtKullaniciAd";
			this.TxtKullaniciAd.Size = new System.Drawing.Size(315, 26);
			this.TxtKullaniciAd.TabIndex = 3;
			this.TxtKullaniciAd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(70, 107);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Kullanıcı Ad:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(123, 155);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Şifre:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightCoral;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(1, -1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(655, 84);
			this.panel1.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(97, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(474, 30);
			this.label3.TabIndex = 7;
			this.label3.Text = "Öğrenci Yurt Kayıt Otomasyonu Sistemi";
			// 
			// FrmAdminGiris
			// 




			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SeaShell;
			this.ClientSize = new System.Drawing.Size(655, 366);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TxtKullaniciAd);
			this.Controls.Add(this.TxtSifre);
			this.Controls.Add(this.button1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmAdminGiris";
			this.Text = "FrmAdminGiris";
			this.Load += new System.EventHandler(this.FrmAdminGiris_Load);
			//((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		
		private System.Diagnostics.PerformanceCounter performanceCounter1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox TxtSifre;
		private System.Windows.Forms.TextBox TxtKullaniciAd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;

		

	}
}