using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
			// TODO: This line of code loads data into the 'yurtKayıtDataSet18.Ogrenci' table. You can move, or remove it, as needed.
			this.ogrenciTableAdapter3.Fill(this.yurtKayıtDataSet18.Ogrenci);
			// TODO: This line of code loads data into the 'yurtKayıtDataSet16.Ogrenci' table. You can move, or remove it, as needed.
			this.ogrenciTableAdapter2.Fill(this.yurtKayıtDataSet16.Ogrenci);
			FrmAdminGiris adminGiris = new FrmAdminGiris();
            adminGiris.Show();


			// TODO: This line of code loads data into the 'yurtKayıtDataSet3.Ogrenci' table. You can move, or remove it, as needed.
			//this.ogrenciTableAdapter1.Fill(this.yurtKayıtDataSet3.Ogrenci);
			// TODO: This line of code loads data into the 'yurtKayıtDataSet1.Ogrenci' table. You can move, or remove it, as needed.
			//this.ogrenciTableAdapter.Fill(this.yurtKayıtDataSet1.Ogrenci);
			timer1.Start();

			//this.ogrenciTableAdapter.Fill(this.yurtKayıtDataSet1.Ogrenci);

		}

		private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text=DateTime.Now.ToLongTimeString();
        }

		private void hEsapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
		{
            System.Diagnostics.Process.Start("Calc.exe");
		}

		private void paintToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("MsPaint.exe");

		}

		private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
		{

		}

		private void radyo1ToolStripMenuItem_Click(object sender, EventArgs e)
		{
	     axWindowsMediaPlayer1.URL="https://moondigitaledge.radyotvonline.net/radyolanddo";

		}

		private void radyo2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			axWindowsMediaPlayer1.URL = "https://moondigitalmaster.radyotvonline.net/efsane4";


		}

		private void radyo3ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			axWindowsMediaPlayer1.URL = "http://37.247.98.8/stream/166/\r\n";

		}

		private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmOgrKayit fr = new FrmOgrKayit();
			fr.Show();
		}

		private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
		{
          OgrListe2 fr = new OgrListe2();
			fr.Show();
		}

		private void öğrenciDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OgrListe2 fr = new OgrListe2();
			fr.Show();
		}
		
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			FrmOgrDuzenle frduz = new FrmOgrDuzenle();	
			frduz.Show();

		

		}

		private void gelirİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmGelirIstatistik fr = new FrmGelirIstatistik();
			fr.Show();
		}

		private void gİderEkleToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			FrmGider frgdr= new FrmGider();
			frgdr.Show();
		}

		private void notEkleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmNotEkle fr = new FrmNotEkle();
			fr.Show();
		}

		private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Bu program...","öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
