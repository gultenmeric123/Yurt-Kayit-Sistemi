using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    public partial class MainForm : Form
    {
        private string connectionString = "Data Source=ZUKOISREAL\\SQLEXPRESS;Initial Catalog=YurtKayıt;Integrated Security=True";

        private string backupFilePath = @"C:\Path\To\Your\BackupFile.bak";
        private string restoreFilePath = @"C:\Path\To\Your\RestoreFile.bak";

        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            // Veritabanından öğrenci bilgilerini yükle
            using (SqlConnection connection = new SqlConnection("Data Source=ZUKOISREAL\\SQLEXPRESS;Initial Catalog=YurtKayıt;Integrated Security=True"))
            {
                string query = "SELECT * FROM Ogrenci";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView2.DataSource = table;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Seçili öğrenciyi sil
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int selectedStudentID = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["StudentID"].Value);

                using (SqlConnection connection = new SqlConnection("Data Source=ZUKOISREAL\\SQLEXPRESS;Initial Catalog=YurtKayıt;Integrated Security=True"))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM Students WHERE StudentID = @StudentID";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", selectedStudentID);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Öğrenci bilgisi başarıyla silindi.");
                    LoadData(); // Verileri güncelle
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir öğrenci seçin.");
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            // Tablo içeriğini yedekleme işlemi
            using (SqlConnection connection = new SqlConnection("Data Source=ZUKOISREAL\\SQLEXPRESS;Initial Catalog=YurtKayıt;Integrated Security=True"))
            {
                connection.Open();

                // Verileri yedekleme SQL sorgusu
                string backupQuery = $"BACKUP TABLE Students TO DISK = '{backupFilePath}'";

                using (SqlCommand cmd = new SqlCommand(backupQuery, connection))
                {
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Tablo içeriği başarıyla yedeklendi.");
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            // Tablo içeriğini geri yükleme işlemi
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Verileri geri yükleme SQL sorgusu
                string restoreQuery = $"RESTORE TABLE Students FROM DISK = '{restoreFilePath}'";

                using (SqlCommand cmd = new SqlCommand(restoreQuery, connection))
                {
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Tablo içeriği başarıyla geri yüklendi.");
                LoadData(); // Verileri güncelle
            }
        }

       
    }
}
