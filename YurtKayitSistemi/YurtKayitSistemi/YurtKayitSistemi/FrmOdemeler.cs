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
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayıtDataSet7.Borclar' table. You can move, or remove it, as needed.
            this.borclarTableAdapter3.Fill(this.yurtKayıtDataSet7.Borclar);
            // TODO: This line of code loads data into the 'yurtKayıtDataSet6.Borclar' table. You can move, or remove it, as needed.
            this.borclarTableAdapter2.Fill(this.yurtKayıtDataSet6.Borclar);
            // TODO: This line of code loads data into the 'yurtKayıtDataSet5.Borclar' table. You can move, or remove it, as needed.
            this.borclarTableAdapter1.Fill(this.yurtKayıtDataSet5.Borclar);
            // TODO: This line of code loads data into the 'yurtKayıtDataSet4.Borclar' table. You can move, or remove it, as needed.
            this.borclarTableAdapter.Fill(this.yurtKayıtDataSet4.Borclar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;
            secilen=dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            TxtAd.Text = ad;
            TxtSoyad.Text = soyad;
            TxtKalan.Text = kalan;
            TxtOgrenciId.Text = id;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnOdemeAl_Click(object sender, EventArgs e)
        {
            //Odenen tutari kalan tutardan dusme
            int odenen, kalan,yeniborc;
            odenen=Convert.ToInt16(TxtOdenen.Text);
            kalan=Convert.ToInt16(TxtKalan.Text);
            yeniborc = kalan - odenen;
            TxtKalan.Text = yeniborc.ToString();


            //Yeni tutari veritabanına kaydetme
            SqlCommand komut=new SqlCommand("update Borclar set OgrKalanBorc=@p1 where OgrId=@p2 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", TxtOgrenciId.Text);
            komut.Parameters.AddWithValue("@p1", TxtKalan.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Borç Ödendi");
            this.borclarTableAdapter.Fill(this.yurtKayıtDataSet4.Borclar);


            //Kasa tablosuna Ekleme yapma
            SqlCommand komut2 = new SqlCommand("insert into Kasa (OdemeAy, OdemeMiktar ) values (@k1, @k2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@k1",label66.Text);
            komut2.Parameters.AddWithValue("@k2", TxtOdenen.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();


        }
    }
}
