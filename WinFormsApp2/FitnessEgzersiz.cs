using System;
using System.Windows.Forms;

namespace FitnessEgzersizApp
{
    public partial class FitnessForm : Form
    {
        private int toplamSure = 0;

        public FitnessForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string egzersizAdi = txtEgzersizAdi.Text.Trim();
            int tekrarSayisi = (int)numTekrarSayisi.Value;
            int sure = (int)numSure.Value;

            // Giriş kontrolleri
            if (string.IsNullOrWhiteSpace(egzersizAdi) || tekrarSayisi <= 0 || sure <= 0)
            {
                MessageBox.Show("Lütfen tüm alanları doğru doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Egzersiz bilgisi ekle
            string egzersizBilgi = $"{egzersizAdi} - {tekrarSayisi} Tekrar - {sure} dk";
            listBoxEgzersizler.Items.Add(egzersizBilgi);

            // Toplam süreyi güncelle
            toplamSure += sure;
            txtToplamSure.Text = toplamSure + " dk";

            // Giriş alanlarını sıfırla
            txtEgzersizAdi.Clear();
            numTekrarSayisi.Value = 1;
            numSure.Value = 1;
        }
    }
}
