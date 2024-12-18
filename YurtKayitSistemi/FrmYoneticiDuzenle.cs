using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtKayitSistemi
{
	public partial class FrmYoneticiDuzenle : Form
	{
		public FrmYoneticiDuzenle()
		{
			InitializeComponent();
		}
		SqlBaglantim bgl = new SqlBaglantim();
		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void Form2_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'yurtKayıtDataSet10.Admin' table. You can move, or remove it, as needed.
			this.adminTableAdapter.Fill(this.yurtKayıtDataSet10.Admin);

		}
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("insert into Admin (YoneticiAd, YoneticiSifre) values (@p1,@p2)", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
			komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Yönetici Eklendi");
			this.adminTableAdapter.Fill(this.yurtKayıtDataSet10.Admin);

		}

		private void BtnSil_Click(object sender, EventArgs e)
		{
			
		SqlCommand komut = new SqlCommand("delete from Admin where YoneticiId=@p1",bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", TxtYoneticiId.Text);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Silme İşlemi Gerçekleşti...");
			this.adminTableAdapter.Fill(this.yurtKayıtDataSet10.Admin);

		
		
		}

		private void BtnGuncelle_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("update admin set YoneticiAd=@p1,YoneticiSifre=@p2 where YoneticiId=@p3",bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
			komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
			komut.Parameters.AddWithValue("@p3", TxtYoneticiId.Text);
			komut.ExecuteNonQuery();
			MessageBox.Show("Güncelleme gerçekleşti...");
			this.adminTableAdapter.Fill(this.yurtKayıtDataSet10.Admin);

		}

		private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			int secilen;
			secilen = dataGridView1.SelectedCells[0].RowIndex;
			string ad, sifre, id;
			id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
			ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
			sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
			TxtKullaniciAd.Text = ad;
			TxtSifre.Text = sifre;
			TxtYoneticiId.Text = id;
		}
	}
}
