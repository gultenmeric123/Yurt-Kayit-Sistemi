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
    public partial class FormBolumler : Form
    {
        public FormBolumler()
        {
            InitializeComponent();
        }

       SqlBaglantim bgl=new SqlBaglantim();


        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormBolumler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayıtDataSet.Bolumler' table. You can move, or remove it, as needed.
            this.bolumlerTableAdapter.Fill(this.yurtKayıtDataSet.Bolumler);

        }

        private void PcbBolumEkle_Click(object sender, EventArgs e)
        {
            try
            {
            
                SqlCommand komut1 = new SqlCommand("insert into Bolumler (BolumAD) values(@p1)", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm Eklendi");
                this.bolumlerTableAdapter.Fill(this.yurtKayıtDataSet.Bolumler);
            }
            catch
            {
                MessageBox.Show("Hata Oluştu Yeniden Deneyiniz");
            }
        }

        private void PcbBolumSil_Click(object sender, EventArgs e)
        {
            try
            {
              
                SqlCommand komut2 = new SqlCommand("delete from Bolumler where BolumId=@p1 ", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", TxtBolumId.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Sİlme İşlemi Gerçekleşti");
                this.bolumlerTableAdapter.Fill(this.yurtKayıtDataSet.Bolumler);

            }

            catch
            {
                MessageBox.Show("Hata, İşlem gerçekleşmedi ");


            }




        }

        int secilen;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolumad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
  
            TxtBolumId.Text = id;
            TxtBolumAd.Text = bolumad;
        }

        private void PcbBolumDuzenle_Click(object sender, EventArgs e)
        {
            try
            {

             
                SqlCommand komut3 = new SqlCommand("update Bolumler Set BolumAd=@p1 where BolumId=@p2 ", bgl.baglanti());
                komut3.Parameters.AddWithValue("p2", TxtBolumId.Text);
                komut3.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme Gerçekleşti");
                this.bolumlerTableAdapter.Fill(this.yurtKayıtDataSet.Bolumler);


            }
            catch 
            {

                MessageBox.Show("Hata");
            }
        }
    }
}
