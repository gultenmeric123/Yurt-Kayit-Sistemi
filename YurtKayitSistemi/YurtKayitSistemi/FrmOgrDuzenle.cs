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
            mskVeliTelefon.Text=velitel;
            richAdres.Text = adres;


        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Ogrenci set OgrAd=@p2, OgrSoyad=@p3, OgrTC=@p4, OgrTelefon=@p5, OgrDogum=@p6,OgrBolum=@p7, OgrMail=@p8, OgrOdaNo=@p9, OgrVeliAdSoyad=@p10, OgrVeliTelefon=@p11, OgrVeliAdres=@p12 where OgrId ",bgl.baglanti());
        }
    }
}
