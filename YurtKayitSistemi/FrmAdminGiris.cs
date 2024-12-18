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
	public partial class FrmAdminGiris : Form
	{
		public FrmAdminGiris()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void FrmAdminGiris_Load(object sender, EventArgs e)
		{

		}


	

		SqlBaglantim bgl =new SqlBaglantim();
		private void button1_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand(	"select*from admin where yoneticiad=@p1 and yoneticisifre=@p2",bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
			komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
			SqlDataReader oku = komut.ExecuteReader();
			if(oku.Read()) 
			{
				//FrmAnaForm fr = new FrmAnaForm();
				//fr.Show();
				//this.Hide();
			}
			else
			{
				MessageBox.Show("Hatalı kulllanıcı adı ya da şifre");
				TxtKullaniciAd.Clear();
				TxtSifre.Clear();
				TxtKullaniciAd.Focus();
			}
			bgl.baglanti().Close();


			//if (TxtKullaniciAd.Text == "admin1"&& TxtSifre.Text== "1234")
			//{

			//	FrmAnaForm fr= new FrmAnaForm();
			//	fr.Show();
			//}
			//else
			//{
			//	MessageBox.Show("hata");


			//}
		}

	}
}
