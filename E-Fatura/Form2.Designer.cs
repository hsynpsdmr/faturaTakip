namespace E_Fatura
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_dSec = new System.Windows.Forms.Button();
            this.txt_Musteri = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Geri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Btn_Ara = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.txt_Musteri_Id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_dSec
            // 
            this.btn_dSec.Location = new System.Drawing.Point(433, 180);
            this.btn_dSec.Name = "btn_dSec";
            this.btn_dSec.Size = new System.Drawing.Size(75, 23);
            this.btn_dSec.TabIndex = 1;
            this.btn_dSec.Text = "Dosya Seç";
            this.btn_dSec.UseVisualStyleBackColor = true;
            this.btn_dSec.Click += new System.EventHandler(this.btn_dSec_Click);
            // 
            // txt_Musteri
            // 
            this.txt_Musteri.Location = new System.Drawing.Point(420, 141);
            this.txt_Musteri.Name = "txt_Musteri";
            this.txt_Musteri.Size = new System.Drawing.Size(100, 20);
            this.txt_Musteri.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dosya Bilgisi Getirme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Geri
            // 
            this.btn_Geri.Location = new System.Drawing.Point(13, 13);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(75, 23);
            this.btn_Geri.TabIndex = 0;
            this.btn_Geri.Text = "GERİ\r\n";
            this.btn_Geri.UseVisualStyleBackColor = true;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Faturasını Eklemek İstediğiniz Müşteriyi Tablodan Seçin";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(13, 131);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(152, 20);
            this.txtSearch.TabIndex = 65;
            // 
            // Btn_Ara
            // 
            this.Btn_Ara.Location = new System.Drawing.Point(171, 129);
            this.Btn_Ara.Name = "Btn_Ara";
            this.Btn_Ara.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ara.TabIndex = 64;
            this.Btn_Ara.Text = "ARA";
            this.Btn_Ara.UseVisualStyleBackColor = true;
            this.Btn_Ara.Click += new System.EventHandler(this.Btn_Ara_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(601, 152);
            this.dataGridView1.TabIndex = 66;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Müşteri İsmi Arayın";
            // 
            // btn_Listele
            // 
            this.btn_Listele.Location = new System.Drawing.Point(13, 201);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(176, 23);
            this.btn_Listele.TabIndex = 68;
            this.btn_Listele.Text = "MÜŞTERİ İSİMLERİNİ LİSTELE";
            this.btn_Listele.UseVisualStyleBackColor = true;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // txt_Musteri_Id
            // 
            this.txt_Musteri_Id.Location = new System.Drawing.Point(382, 141);
            this.txt_Musteri_Id.Name = "txt_Musteri_Id";
            this.txt_Musteri_Id.Size = new System.Drawing.Size(32, 20);
            this.txt_Musteri_Id.TabIndex = 69;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E_Fatura.Properties.Resources.c01e2326a1720a9ea4c86928d7a21414;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(622, 394);
            this.Controls.Add(this.txt_Musteri_Id);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.Btn_Ara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.txt_Musteri);
            this.Controls.Add(this.btn_dSec);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dosya İşlemleri";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_dSec;
        private System.Windows.Forms.TextBox txt_Musteri;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Geri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button Btn_Ara;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.TextBox txt_Musteri_Id;
    }
}