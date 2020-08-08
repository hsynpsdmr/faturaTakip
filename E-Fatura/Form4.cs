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
    public partial class Form4 : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=eFatura;Integrated Security=True");

        public Form4()
        {
            InitializeComponent();
        }
        void listeleme()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connect;
                command.CommandText = "SELECT dbo.Fatura.Musteri_Id, dbo.Musteri.Ad_Soyad, dbo.Musteri.Aldigi_Hizmet,dbo.Fatura.filePath FROM dbo.Musteri INNER JOIN dbo.Fatura ON dbo.Musteri.Musteri_Id = dbo.Fatura.Musteri_Id";
                SqlDataAdapter dAdapter = new SqlDataAdapter(command);
                DataSet dSet = new DataSet();
                dAdapter.Fill(dSet, "dbo.Fatura");
                dataGridView1.DataSource = dSet.Tables["dbo.Fatura"];
                connect.Close();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            listeleme();
            
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string belge;
            belge = @""+textBox1.Text+"";
            System.Diagnostics.Process.Start(belge);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
