using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace E_Fatura
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=eFatura;Integrated Security=True");



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listeleme();

            cbSearch.SelectedIndex = 0;
        }
        void temizleme()
        {
            txtAdSoyad.Text = "";
            txtAldigiHizmet.Text = "";
            txtTelefon.Text = "";
            txtAdres.Text = "";
            cbGun.Text = "";
            cbAy.Text = "";
            cbYil.Text = "";

        }
        void listeleme()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connect;
                command.CommandText = "select * from dbo.Musteri";
                SqlDataAdapter dAdapter = new SqlDataAdapter(command);
                DataSet dSet = new DataSet();
                dAdapter.Fill(dSet, "dbo.Musteri");
                dataGridView1.DataSource = dSet.Tables["dbo.Musteri"];
                dataGridView1.Columns[0].Visible = false; 
                connect.Close();
            }
        }
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connect;
                command.CommandText = "INSERT INTO dbo.Musteri(Ad_Soyad,Telefon,Adres,Aldigi_Hizmet,Gun,Ay,Yil) VALUES ('" 
                    + txtAdSoyad.Text + "','" + txtTelefon.Text + "','" + txtAdres.Text + "','" + txtAldigiHizmet.Text + "','" + int.Parse(cbGun.Text) + "','" + int.Parse(cbAy.Text) + "','" + int.Parse(cbYil.Text) + "')";
                command.ExecuteNonQuery();
                command.Dispose();
                connect.Close();
                listeleme();
                temizleme();
                MessageBox.Show("KAYIT EKLENDİ");
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SİLMEK İSTEDİĞİNİZE EMİNMİSİNİZ?", "UYARI!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connect;
                    command.CommandText = "delete from dbo.Musteri where Musteri_Id=@numara";
                    command.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    command.ExecuteNonQuery();
                    command.Dispose();
                    connect.Close();
                    listeleme();
                    MessageBox.Show("KAYIT SİLİNMİŞTİR");
                }
            }



        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAldigiHizmet.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cbGun.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cbAy.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cbYil.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void Btn_Ara_Click(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
            {
                string cmdText = "SELECT * From dbo.Musteri WHERE " + cbSearch.Text + " like '%'+ @input+'%'";

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

        private void btn_IO_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("GÜNCELLEME YAPMAK İSTEDİĞİNİZE EMİNMİSİNİZ?", "UYARI!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connect;
                    command.CommandText = " update dbo.Musteri set Ad_Soyad='" + txtAdSoyad.Text + "',Aldigi_Hizmet='" + txtAldigiHizmet.Text + "',Telefon='" + txtTelefon.Text + "',Adres='" + txtAdres.Text + "',Gun='" + int.Parse(cbGun.Text) + "',Ay='" + int.Parse(cbAy.Text) + "',Yil='" + int.Parse(cbYil.Text) + "'where Musteri_Id=@numara";
                    command.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    command.ExecuteNonQuery();
                    command.Dispose();
                    connect.Close();
                    listeleme();
                    temizleme();
                    MessageBox.Show("KAYIT GÜNCELLENMİŞTİR");

                }
            }
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
