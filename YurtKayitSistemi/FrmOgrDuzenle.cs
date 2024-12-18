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
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }
        public string id,ad,soyad,TC,telefon,dogum,bolum;

		public string mail, odano, veliad, velitel, adres;

        SqlBaglantim bgl = new SqlBaglantim();
		private object yurtKayıtDataSet16;

		public object OgrenciTableAdapter { get; private set; }

		private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
			TxtOgrId.Text = id;
            TxtOgrAd.Text = ad;
            TxtOgrSoyad.Text = soyad;
            MSKTC.Text = TC;
            MSKOgrTelefon.Text = telefon;
            MskDogumTarihi.Text = dogum;
            CmbBolum.Text = bolum;
            TxtMail.Text = mail;
            CmbOdoNo.Text = odano;
            TxtVeliAdSoyad.Text = veliad;
            mskVeliTelefon.Text = velitel;
            richAdres.Text = adres;



		}
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
            SqlCommand komut = new SqlCommand("update Ogrenci set OgrAd=@p2, OgrSoyad=@p3, OgrTC=@p4, OgrTelefon=@p5, OgrDogum=@p6,OgrBolum=@p7, OgrMail=@p8, OgrOdaNo=@p9, OgrVeliAdSoyad=@p10, OgrVeliTelefon=@p11, OgrVeliAdres=@p12 where OgrId=@p1 ",bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtOgrId.Text);
				komut.Parameters.AddWithValue("@p2", TxtOgrAd.Text);
				komut.Parameters.AddWithValue("@p3", TxtOgrSoyad.Text);
				komut.Parameters.AddWithValue("@p4", MSKTC.Text);
				komut.Parameters.AddWithValue("@p5", MSKOgrTelefon.Text);
				komut.Parameters.AddWithValue("@p6", MskDogumTarihi.Text);
				komut.Parameters.AddWithValue("@p7", CmbBolum.Text);
				komut.Parameters.AddWithValue("@p8", TxtMail.Text);
				komut.Parameters.AddWithValue("@p9", CmbOdoNo.Text);
				komut.Parameters.AddWithValue("@p10", TxtVeliAdSoyad.Text);
				komut.Parameters.AddWithValue("@p11", mskVeliTelefon.Text);
				komut.Parameters.AddWithValue("@p12", richAdres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Kayıt Güncellendi");

			}
            catch (Exception)
            {
                MessageBox.Show("Hata, yeniden deneyin");
            }
		}
		private void ogrSil_Click(object sender, EventArgs e)
		{
			SqlCommand komutsil = new SqlCommand("delete from Ogrenci where ogrid=@k1", bgl.baglanti());
			komutsil.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Kayıt Silindi.");

			//oda kontenjanı artırma
			SqlCommand komutoda = new SqlCommand("update odalar set OdaAktif= OdaAktif+1 where OdaNo=@oda", bgl.baglanti());
			komutoda.Parameters.AddWithValue("@oda", CmbOdoNo.Text);
			komutoda.ExecuteNonQuery();
			bgl.baglanti().Close();

		}


	}
}
