using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class yemektakip : Form
    {
        // Yemek öğeleri listeleri
        private List<string> kahvaltiListesi = new List<string>();
        private List<string> ogleYemegiListesi = new List<string>();
        private List<string> aksamYemegiListesi = new List<string>();
        private List<string> aperatifListesi = new List<string>();

        public yemektakip()
        {
            InitializeComponent();
        }

        private void btnKahvaltiEkle_Click(object sender, EventArgs e)
        {
            EkleOge("Kahvaltı", kahvaltiListesi);
        }

        private void btnOgleYemegiEkle_Click(object sender, EventArgs e)
        {
            EkleOge("Öğle Yemeği", ogleYemegiListesi);
        }

        private void btnAksamYemegiEkle_Click(object sender, EventArgs e)
        {
            EkleOge("Akşam Yemeği", aksamYemegiListesi);
        }

        private void btnAperatifEkle_Click(object sender, EventArgs e)
        {
            EkleOge("Aperatif", aperatifListesi);
        }

        private void EkleOge(string kategoriAdi, List<string> liste)
        {
            // Kullanıcıdan veri almak için input kutusu
            string yeniOge = Microsoft.VisualBasic.Interaction.InputBox(
                $"Lütfen {kategoriAdi} için bir öğe ekleyin:",
                "Öğe Ekle",
                ""
            );

            if (!string.IsNullOrEmpty(yeniOge))
            {
                liste.Add(yeniOge);
                MessageBox.Show($"{kategoriAdi} listesine '{yeniOge}' eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Öğeyi ListBox'a ekleme
                ListBoxEkle(yeniOge);
            }
            else
            {
                MessageBox.Show("Boş bir öğe eklenemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ListBoxEkle(string yeniOge)
        {
            // Yemek öğelerini tüm kategorilerde birleştirip ListBox'a ekliyoruz
            listBoxYemekler.Items.Clear(); // Önceki öğeleri temizle

            // Tüm listeleri birleştir
            var tumYemekler = new List<string>();
            tumYemekler.AddRange(kahvaltiListesi);
            tumYemekler.AddRange(ogleYemegiListesi);
            tumYemekler.AddRange(aksamYemegiListesi);
            tumYemekler.AddRange(aperatifListesi);

            // Listeyi ListBox'a ekle
            foreach (var yemek in tumYemekler)
            {
                listBoxYemekler.Items.Add(yemek);
            }
        }

        private void yemektakip_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde ilk başta ListBox'ı doldur
            ListBoxEkle(string.Empty);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
