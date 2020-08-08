using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Fatura
{
    public partial class Form2 : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=eFatura;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }
        void DosyaTaşıma(String Musteri)
        {
            OpenFileDialog file = new OpenFileDialog();
            //file.Filter = "Excel Dosyası |*.xlsx| Excel Dosyası|*.xls";  
            //file.FilterIndex = 2;

            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            //file.Title = "Excel Dosyası Seçiniz..";
            file.ShowDialog();

            string DosyaYolu = file.FileName;
            string DosyaAdi = file.SafeFileName;

            File.Move(@DosyaYolu, @"D:\Faturalar\"+Musteri+ "\\" + DosyaAdi);
            MessageBox.Show("Dosya Taşındı");
            String path = @"D:\Faturalar\" + Musteri + "\\" + DosyaAdi;
            DosyaPath(path);

        }
        void DosyaPath(String Path)
        {
            if (connect.State == ConnectionState.Closed)
            {
                String MusteriId = txt_Musteri_Id.Text;
                connect.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connect;
                command.CommandText = "insert into dbo.Fatura (Musteri_Id,filePath) values ('" + MusteriId + "','" + Path + "')";
                command.ExecuteNonQuery();
                command.Dispose();
                connect.Close();
                listeleme();
                MessageBox.Show("KAYIT EKLENDİ");
            }
        }
        void listeleme()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connect;
                command.CommandText = "select Musteri_Id,Ad_soyad from dbo.Musteri";
                SqlDataAdapter dAdapter = new SqlDataAdapter(command);
                DataSet dSet = new DataSet();
                dAdapter.Fill(dSet, "dbo.Musteri");
                dataGridView1.DataSource = dSet.Tables["dbo.Musteri"];
                connect.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            //if (Directory.Exists(@"D:\Faturalar"))
            //{
            //    MessageBox.Show("Evet var");
            //}

            //else
            //{
            //    MessageBox.Show("Hayır yok");
            //    Directory.CreateDirectory(@"D:\Faturalar");
            //    DateTime olusturmaZamani = Directory.GetCreationTime("Faturalar");
            //    DateTime sonErisimZamani = Directory.GetLastAccessTime("Faturalar");
            //    DateTime sonYazimZamani = Directory.GetLastWriteTime("Faturalar");
            //    MessageBox.Show("Oluşturma Zamanı " + olusturmaZamani.ToString() + "\nSon Erişim Zamanı " + sonErisimZamani.ToString() + "\nSon Yazım Zamanı " + sonYazimZamani.ToString(), "BİLGİLENDİRME!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //File.Move(@"D:\deneme.txt", @"D:\Faturalar\deneme.txt");
            //if (File.Exists(@"D:\Faturalar\deneme.txt"))
            //    MessageBox.Show("Dosya bulundu.");
            //else
            //    MessageBox.Show("Dosya mevcut değil.");
        }


        private void btn_dSec_Click(object sender, EventArgs e)
        {
            String Musteri = txt_Musteri.Text;
            if (Directory.Exists(@"D:\Faturalar\" + Musteri))
            {
                DosyaTaşıma(Musteri);
            }

            else
            {
                Directory.CreateDirectory(@"D:\Faturalar\" + Musteri);
                DosyaTaşıma(Musteri);
            }
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listeleme();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Musteri_Id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_Musteri.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void Btn_Ara_Click(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
            {
                string cmdText = "SELECT Ad_Soyad From dbo.Musteri WHERE Ad_Soyad like '%'+ @input+'%'";

                using (SqlCommand cmd = new SqlCommand(cmdText, connect))
                {

                    connect.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    cmd.Parameters.AddWithValue("@input", txtSearch.Text);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    connect.Close();
                    txtSearch.Text = "";
                }

            }
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            listeleme();
        }
    }
}
