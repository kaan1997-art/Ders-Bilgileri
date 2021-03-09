using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DersBilgileri.Business;
using DersBilgileri.DataAccess;
using DersBilgileri.DataAccess.Bases;
using DersBilgileri.Models;
using DersBilgileri1;

namespace DersBilgileri
{
    public partial class Form1 : Form

    {
        DersService service;
        public Form1()
        {
            InitializeComponent();
            OperationBase operation = new MemoryOperations();
            service = new DersService(operation);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = DersBilgileriConfig.Baslik;
            FillGrid();
            FillNotlar();
        }

        private void FillGrid()
        {
            dgvDersler.DataSource = service.GetDersler().ToList();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            dgvDersler.ClearSelection();
        }

        private void FillNotlar()
        {
            Models.Kategori kategori;

            List<Models.Kategori> kategoriler = new List<Models.Kategori>();
            kategori = new Models.Kategori()
            {
                Value = (int)Enums.KategoriEnum.Kategori1,
                Text = Enums.KategoriEnum.Kategori1.ToString()
            };
            kategoriler.Add(kategori);

            kategoriler.Add(new Models.Kategori { Value = (int)Enums.KategoriEnum.Kategori2, Text = Enums.KategoriEnum.Kategori2.ToString() });
            kategoriler.Add(new Models.Kategori { Value = (int)Enums.KategoriEnum.Kategori3, Text = Enums.KategoriEnum.Kategori3.ToString() });
            kategoriler.Add(new Models.Kategori { Value = (int)Enums.KategoriEnum.Kategori4, Text = Enums.KategoriEnum.Kategori4.ToString() });
            kategoriler.Add(new Models.Kategori { Value = (int)Enums.KategoriEnum.Kategori5, Text = Enums.KategoriEnum.Kategori5.ToString() });

            kategoriler.Insert(0, new Models.Kategori { Value = 0, Text = "Seçiniz" });

            cbKategori.DataSource = kategoriler;
            cbKategori.ValueMember = "Value";
            cbKategori.DisplayMember = "Text";
        }        

        private void bDers_Click_1(object sender, EventArgs e)
        {
            if (dgvDersler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir kayıt seçiniz.");
                return;
            }
            int id = Convert.ToInt32(dgvDersler.SelectedRows[0].Cells["Id"].Value);
            Ders ders = service.GetDers(id);
            MessageBox.Show("ID: " + ders.Id + "\nAdı: " + ders.Adi + "\nKonusu: " + ders.Konular + "\nKredisi: " + ders.Kredi + "\nKategorisi: " + ders.Kategori);
        }

        private void bSil_Click_1(object sender, EventArgs e)
        {
            if (dgvDersler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silmek için en az 1 ders seçiniz!");
                return;
            }

            int Id = Convert.ToInt32(dgvDersler.SelectedRows[0].Cells["Id"].Value);
            service.Delete(Id);
            FillGrid();
        }

        private void bEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAdi.Text) && string.IsNullOrWhiteSpace(rtbKonular.Text))
            {
                MessageBox.Show("Ders ve konuyu giriniz!");
                return;
            }

            if (tbKredi.Text == null)
            {
                MessageBox.Show("Kredi giriniz!");
                return;
            }


            if (cbKategori.SelectedIndex == 0)
            {
                MessageBox.Show("Ders kategorisi giriniz!");
                return;
            }

            Ders ders = new Ders()
            {
                Adi = tbAdi.Text.Trim(),
                Konular = rtbKonular.Text,
                Kategori = (Enums.KategoriEnum)cbKategori.SelectedValue,
                Kredi = Convert.ToInt16(tbKredi.Text)
            };

            service.AddDers(ders);
            FillGrid();
        }
    }
}