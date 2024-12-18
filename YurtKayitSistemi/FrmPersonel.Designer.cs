namespace YurtKayitSistemi
{
	partial class FrmPersonel
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
			this.TxtPersonelId = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.TxtPersonelAd = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.TxtPersonelGorev = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.BtnGuncelle = new System.Windows.Forms.Button();
			this.BtnKaydet = new System.Windows.Forms.Button();
			this.BtnSil = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.personelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.personelAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.personelDepartmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.yurtKayıtDataSet11 = new YurtKayitSistemi.YurtKayıtDataSet11();
			this.personelTableAdapter = new YurtKayitSistemi.YurtKayıtDataSet11TableAdapters.PersonelTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.yurtKayıtDataSet11)).BeginInit();
			this.SuspendLayout();
			// 
			// TxtPersonelId
			// 
			this.TxtPersonelId.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.TxtPersonelId.Location = new System.Drawing.Point(228, 24);
			this.TxtPersonelId.Margin = new System.Windows.Forms.Padding(4);
			this.TxtPersonelId.Name = "TxtPersonelId";
			this.TxtPersonelId.Size = new System.Drawing.Size(217, 37);
			this.TxtPersonelId.TabIndex = 27;
			this.TxtPersonelId.TextChanged += new System.EventHandler(this.TxtOgrAd_TextChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label13.Location = new System.Drawing.Point(79, 27);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(135, 30);
			this.label13.TabIndex = 26;
			this.label13.Text = "Personel id:";
			this.label13.Click += new System.EventHandler(this.label13_Click);
			// 
			// TxtPersonelAd
			// 
			this.TxtPersonelAd.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.TxtPersonelAd.Location = new System.Drawing.Point(228, 69);
			this.TxtPersonelAd.Margin = new System.Windows.Forms.Padding(4);
			this.TxtPersonelAd.Name = "TxtPersonelAd";
			this.TxtPersonelAd.Size = new System.Drawing.Size(217, 37);
			this.TxtPersonelAd.TabIndex = 29;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(79, 72);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 30);
			this.label1.TabIndex = 28;
			this.label1.Text = "Personel Ad:";
			// 
			// TxtPersonelGorev
			// 
			this.TxtPersonelGorev.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.TxtPersonelGorev.Location = new System.Drawing.Point(228, 112);
			this.TxtPersonelGorev.Margin = new System.Windows.Forms.Padding(4);
			this.TxtPersonelGorev.Name = "TxtPersonelGorev";
			this.TxtPersonelGorev.Size = new System.Drawing.Size(217, 37);
			this.TxtPersonelGorev.TabIndex = 31;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(64, 115);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(169, 30);
			this.label2.TabIndex = 30;
			this.label2.Text = "Personel Gorev:";
			// 
			// BtnGuncelle
			// 
			this.BtnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnGuncelle.Location = new System.Drawing.Point(398, 200);
			this.BtnGuncelle.Name = "BtnGuncelle";
			this.BtnGuncelle.Size = new System.Drawing.Size(120, 32);
			this.BtnGuncelle.TabIndex = 35;
			this.BtnGuncelle.Text = "Güncelle";
			this.BtnGuncelle.UseVisualStyleBackColor = true;
			this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
			// 
			// BtnKaydet
			// 
			this.BtnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnKaydet.Location = new System.Drawing.Point(127, 200);
			this.BtnKaydet.Name = "BtnKaydet";
			this.BtnKaydet.Size = new System.Drawing.Size(120, 32);
			this.BtnKaydet.TabIndex = 34;
			this.BtnKaydet.Text = "Kaydet";
			this.BtnKaydet.UseVisualStyleBackColor = true;
			this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
			// 
			// BtnSil
			// 
			this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnSil.Location = new System.Drawing.Point(263, 200);
			this.BtnSil.Name = "BtnSil";
			this.BtnSil.Size = new System.Drawing.Size(120, 32);
			this.BtnSil.TabIndex = 33;
			this.BtnSil.Text = "Sil";
			this.BtnSil.UseVisualStyleBackColor = true;
			this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelIdDataGridViewTextBoxColumn,
            this.personelAdSoyadDataGridViewTextBoxColumn,
            this.personelDepartmanDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.personelBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(34, 254);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(601, 160);
			this.dataGridView1.TabIndex = 36;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// personelIdDataGridViewTextBoxColumn
			// 
			this.personelIdDataGridViewTextBoxColumn.DataPropertyName = "PersonelId";
			this.personelIdDataGridViewTextBoxColumn.HeaderText = "PersonelId";
			this.personelIdDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.personelIdDataGridViewTextBoxColumn.Name = "personelIdDataGridViewTextBoxColumn";
			this.personelIdDataGridViewTextBoxColumn.ReadOnly = true;
			this.personelIdDataGridViewTextBoxColumn.Width = 125;
			// 
			// personelAdSoyadDataGridViewTextBoxColumn
			// 
			this.personelAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "PersonelAdSoyad";
			this.personelAdSoyadDataGridViewTextBoxColumn.HeaderText = "PersonelAdSoyad";
			this.personelAdSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.personelAdSoyadDataGridViewTextBoxColumn.Name = "personelAdSoyadDataGridViewTextBoxColumn";
			this.personelAdSoyadDataGridViewTextBoxColumn.Width = 125;
			// 
			// personelDepartmanDataGridViewTextBoxColumn
			// 
			this.personelDepartmanDataGridViewTextBoxColumn.DataPropertyName = "PersonelDepartman";
			this.personelDepartmanDataGridViewTextBoxColumn.HeaderText = "PersonelDepartman";
			this.personelDepartmanDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.personelDepartmanDataGridViewTextBoxColumn.Name = "personelDepartmanDataGridViewTextBoxColumn";
			this.personelDepartmanDataGridViewTextBoxColumn.Width = 125;
			// 
			// personelBindingSource
			// 
			this.personelBindingSource.DataMember = "Personel";
			this.personelBindingSource.DataSource = this.yurtKayıtDataSet11;
			// 
			// yurtKayıtDataSet11
			// 
			this.yurtKayıtDataSet11.DataSetName = "YurtKayıtDataSet11";
			this.yurtKayıtDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// personelTableAdapter
			// 
			this.personelTableAdapter.ClearBeforeFill = true;
			// 
			// FrmPersonel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(686, 455);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.BtnGuncelle);
			this.Controls.Add(this.BtnKaydet);
			this.Controls.Add(this.BtnSil);
			this.Controls.Add(this.TxtPersonelGorev);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TxtPersonelAd);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TxtPersonelId);
			this.Controls.Add(this.label13);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmPersonel";
			this.Text = "Personel";
			this.Load += new System.EventHandler(this.FrmPersonel_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.yurtKayıtDataSet11)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TxtPersonelId;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox TxtPersonelAd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxtPersonelGorev;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button BtnGuncelle;
		private System.Windows.Forms.Button BtnKaydet;
		private System.Windows.Forms.Button BtnSil;
		private System.Windows.Forms.DataGridView dataGridView1;
		private YurtKayıtDataSet11 yurtKayıtDataSet11;
		private System.Windows.Forms.BindingSource personelBindingSource;
		private YurtKayıtDataSet11TableAdapters.PersonelTableAdapter personelTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn personelIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn personelAdSoyadDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn personelDepartmanDataGridViewTextBoxColumn;
	}
}