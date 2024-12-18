using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
	public partial class OgrListe2 : Form
	{
		public OgrListe2()
		{
			InitializeComponent();
		}

		private void OgrListe2_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'yurtKayıtDataSet14.Ogrenci' table. You can move, or remove it, as needed.
			this.ogrenciTableAdapter.Fill(this.yurtKayıtDataSet14.Ogrenci);
			SqlConnection connection = new SqlConnection("Data Source=LAPTOP-CHVDTKO4\\SQLEXPRESS;Initial Catalog=YurtKayıt;Integrated Security=True");
			connection.Open();
			// TODO: This line of code loads data into the 'yurtKayıtDataSet8.Ogrenci' table. You can move, or remove it, as needed.
			SqlDataAdapter sqlData = new SqlDataAdapter("select * from Ogrenci", connection);
			DataSet ds = new DataSet();
		//	sqlData.Fill(ds, "Ogrenci");
			dataGridView1.CellClick += dataGridView1_CellClick;
			connection.Close();
		}
		int secilen;
		public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			
			
			secilen = dataGridView1.SelectedCells[0].RowIndex;
			FrmOgrDuzenle fr = new FrmOgrDuzenle();
			fr.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
			fr.ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
			fr.soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
			fr.TC = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
			fr.telefon = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
			fr.dogum = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
			fr.bolum = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
			fr.mail = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
			fr.odano = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
			fr.veliad = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
			fr.velitel = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
			fr.adres = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
			fr.Show();

		}
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			FrmOgrDuzenle fr = new FrmOgrDuzenle();
			fr.Show();
		}
	}
}
