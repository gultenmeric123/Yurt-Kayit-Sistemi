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
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl=new SqlBaglantim();
       
        private void Form1_Load(object sender, EventArgs e)
        {//yazdıgımız bolumlerin gelmesini sağladı veritabanından (baglantilari listeleme
            
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler", bgl.baglanti());
            SqlDataReader oku=komut.ExecuteReader();
            while (oku.Read())
            {
                CmbBolum.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();
            //Boş odaları listeleme komutları 

            SqlCommand komut2 = new SqlCommand("Select OdaNo From Odalar where OdaKapasite ! =OdaAktif", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                CmbOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Öğrenci bilgilerinin kayıt edilme komutları

           try
           {
              
            SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci (OgrAd, OgrSoyad, OgrTC, OgrTelefon, OgrDogum, OgrBolum, OgrMail, OgrOdaNo, OgrVeliAdSoyad, OgrVeliTelefon, OgrVeliAdres )values(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", TxtOgrAd.Text);
            komutkaydet.Parameters.AddWithValue("@p2", TxtOgrSoyad.Text);
            komutkaydet.Parameters.AddWithValue("@p3", MSKTC.Text);
            komutkaydet.Parameters.AddWithValue("@p4", MSKOgrTelefon.Text);
            komutkaydet.Parameters.AddWithValue("@p5", MskDogumTarihi.Text);
            komutkaydet.Parameters.AddWithValue("@p6", CmbBolum.Text);
            komutkaydet.Parameters.AddWithValue("@p7", TxtMail.Text);
            komutkaydet.Parameters.AddWithValue("@p8", CmbOdaNo.Text);
            komutkaydet.Parameters.AddWithValue("@p9", TxtVeliAdSoyad.Text);
            komutkaydet.Parameters.AddWithValue("@p10", mskVeliTelefon.Text);
            komutkaydet.Parameters.AddWithValue("@p11", richAdres.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
             MessageBox.Show("Kayıt Başarılı Bir Şekilde Eklendi");


                //öğrenci id'yi labele çekme
                SqlCommand komut = new SqlCommand("select OgrId from Ogrenci", bgl.baglanti());
                SqlDataReader oku=komut.ExecuteReader();
                while (oku.Read())
                {
                    label12.Text = oku[0].ToString();
                }
                bgl.baglanti().Close();

                 
                //Öğrenci borç alanı oluşturma
                SqlCommand komutkaydet2 = new SqlCommand("insert into Borclar  (OgrId, OgrAd, OgrSoyad) values (@b1,@b2,@b3)", bgl.baglanti());
                komutkaydet2.Parameters.AddWithValue("@b1", label12.Text);
                komutkaydet2.Parameters.AddWithValue("@b2", TxtOgrAd.Text);
                komutkaydet2.Parameters.AddWithValue("b3", TxtOgrSoyad.Text);
                komutkaydet2.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
           catch (Exception)
           {

              MessageBox.Show("HATA!! Lütfen yeniden deneyin");
            }

            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif+1 where OdaNo=@oda1", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda1", CmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();




        }

		private void TxtOgrAd_TextChanged(object sender, EventArgs e)
		{

		}

		private void label12_Click(object sender, EventArgs e)
		{

		}
	}
}
//Data Source=LAPTOP-4HH6PT7H\SQLEXPRESS;Initial Catalog=YurtKayıt;Integrated Security=True