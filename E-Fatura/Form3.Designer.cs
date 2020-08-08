namespace E_Fatura
{
    partial class Form3
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
            this.btn_Musteri = new System.Windows.Forms.Button();
            this.btn_fDepolama = new System.Windows.Forms.Button();
            this.btn_Fatura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Musteri
            // 
            this.btn_Musteri.Location = new System.Drawing.Point(178, 88);
            this.btn_Musteri.Name = "btn_Musteri";
            this.btn_Musteri.Size = new System.Drawing.Size(102, 23);
            this.btn_Musteri.TabIndex = 0;
            this.btn_Musteri.Text = "Müşteri Kayıt";
            this.btn_Musteri.UseVisualStyleBackColor = true;
            this.btn_Musteri.Click += new System.EventHandler(this.btn_Musteri_Click);
            // 
            // btn_fDepolama
            // 
            this.btn_fDepolama.Location = new System.Drawing.Point(178, 132);
            this.btn_fDepolama.Name = "btn_fDepolama";
            this.btn_fDepolama.Size = new System.Drawing.Size(102, 23);
            this.btn_fDepolama.TabIndex = 1;
            this.btn_fDepolama.Text = "Fatura Depolama";
            this.btn_fDepolama.UseVisualStyleBackColor = true;
            this.btn_fDepolama.Click += new System.EventHandler(this.btn_fDepolama_Click);
            // 
            // btn_Fatura
            // 
            this.btn_Fatura.Location = new System.Drawing.Point(178, 178);
            this.btn_Fatura.Name = "btn_Fatura";
            this.btn_Fatura.Size = new System.Drawing.Size(102, 23);
            this.btn_Fatura.TabIndex = 2;
            this.btn_Fatura.Text = "Faturalar";
            this.btn_Fatura.UseVisualStyleBackColor = true;
            this.btn_Fatura.Click += new System.EventHandler(this.btn_Fatura_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E_Fatura.Properties.Resources.c01e2326a1720a9ea4c86928d7a21414;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(458, 336);
            this.Controls.Add(this.btn_Fatura);
            this.Controls.Add(this.btn_fDepolama);
            this.Controls.Add(this.btn_Musteri);
            this.DoubleBuffered = true;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Musteri;
        private System.Windows.Forms.Button btn_fDepolama;
        private System.Windows.Forms.Button btn_Fatura;
    }
}