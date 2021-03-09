
namespace DersBilgileri
{
    partial class Form1
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
            this.bEkle = new System.Windows.Forms.Button();
            this.bSil = new System.Windows.Forms.Button();
            this.bDers = new System.Windows.Forms.Button();
            this.dgvDersler = new System.Windows.Forms.DataGridView();
            this.tbAdi = new System.Windows.Forms.TextBox();
            this.rtbKonular = new System.Windows.Forms.RichTextBox();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.tbKredi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).BeginInit();
            this.SuspendLayout();
            // 
            // bEkle
            // 
            this.bEkle.Location = new System.Drawing.Point(882, 66);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(75, 47);
            this.bEkle.TabIndex = 0;
            this.bEkle.Text = "Ekle";
            this.bEkle.UseVisualStyleBackColor = true;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // bSil
            // 
            this.bSil.Location = new System.Drawing.Point(882, 157);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(75, 47);
            this.bSil.TabIndex = 1;
            this.bSil.Text = "Sil";
            this.bSil.UseVisualStyleBackColor = true;
            this.bSil.Click += new System.EventHandler(this.bSil_Click_1);
            // 
            // bDers
            // 
            this.bDers.Location = new System.Drawing.Point(882, 242);
            this.bDers.Name = "bDers";
            this.bDers.Size = new System.Drawing.Size(75, 47);
            this.bDers.TabIndex = 2;
            this.bDers.Text = "Ders";
            this.bDers.UseVisualStyleBackColor = true;
            this.bDers.Click += new System.EventHandler(this.bDers_Click_1);
            // 
            // dgvDersler
            // 
            this.dgvDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDersler.Location = new System.Drawing.Point(23, 157);
            this.dgvDersler.Name = "dgvDersler";
            this.dgvDersler.RowHeadersWidth = 62;
            this.dgvDersler.RowTemplate.Height = 28;
            this.dgvDersler.Size = new System.Drawing.Size(828, 281);
            this.dgvDersler.TabIndex = 3;
            // 
            // tbAdi
            // 
            this.tbAdi.Location = new System.Drawing.Point(23, 12);
            this.tbAdi.Name = "tbAdi";
            this.tbAdi.Size = new System.Drawing.Size(136, 26);
            this.tbAdi.TabIndex = 4;
            this.tbAdi.Text = "Adi";
            // 
            // rtbKonular
            // 
            this.rtbKonular.Location = new System.Drawing.Point(23, 44);
            this.rtbKonular.Name = "rtbKonular";
            this.rtbKonular.Size = new System.Drawing.Size(100, 96);
            this.rtbKonular.TabIndex = 5;
            this.rtbKonular.Text = "Konular";
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(193, 10);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(121, 28);
            this.cbKategori.TabIndex = 6;
            this.cbKategori.Text = "Kategori";
            // 
            // tbKredi
            // 
            this.tbKredi.Location = new System.Drawing.Point(193, 54);
            this.tbKredi.Name = "tbKredi";
            this.tbKredi.Size = new System.Drawing.Size(121, 26);
            this.tbKredi.TabIndex = 7;
            this.tbKredi.Text = "Kredi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 498);
            this.Controls.Add(this.tbKredi);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.rtbKonular);
            this.Controls.Add(this.tbAdi);
            this.Controls.Add(this.dgvDersler);
            this.Controls.Add(this.bDers);
            this.Controls.Add(this.bSil);
            this.Controls.Add(this.bEkle);
            this.Name = "Form1";
            this.Text = "DersBilgileri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEkle;
        private System.Windows.Forms.Button bSil;
        private System.Windows.Forms.Button bDers;
        private System.Windows.Forms.DataGridView dgvDersler;
        private System.Windows.Forms.TextBox tbAdi;
        private System.Windows.Forms.RichTextBox rtbKonular;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.TextBox tbKredi;
    }
}

