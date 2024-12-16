using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class UykuTakibi : Form
    {
        public UykuTakibi()
        {
            InitializeComponent();
           
        }

        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            DateTime uykuSaati = dateUykuSaati.Value;
            DateTime uyanmaSaati = datetimeUyanmaSaati.Value;

            TimeSpan uykuSuresi;

            if (uyanmaSaati < uykuSaati)
            {
                uyanmaSaati = uyanmaSaati.AddDays(1);
            }

            uykuSuresi = uyanmaSaati - uykuSaati;

            labelSure.Text = $"{uykuSuresi.Hours} Saat, {uykuSuresi.Minutes} Dakika";

        }

        private void buttonKayit_Click(object sender, EventArgs e)
        {
            DateTime uykuSaati = dateUykuSaati.Value;
            DateTime uyanmaSaati = datetimeUyanmaSaati.Value;

            // Gece yarısını aşan uyku hesaplaması

            if (uyanmaSaati < uykuSaati)
            {
                uyanmaSaati = uyanmaSaati.AddDays(1);
            }

            TimeSpan uykuSuresi = uyanmaSaati - uykuSaati;

            //Kullanıcının girdilerini dosyaya yazma

            string dosyaYolu = "uyku.txt";
            string satir = $"{uykuSaati.Day}{"/"}{uykuSaati.Month}{"/"}{uykuSaati.Year} - {uyanmaSaati.Day}{"/"}{uyanmaSaati.Month}{"/"}{uykuSaati.Month} \n {uykuSuresi.Hours} Saat, {uykuSuresi.Minutes} Dakika \n";
            File.AppendAllText(dosyaYolu, satir + Environment.NewLine);

            MessageBox.Show("Verileriniz başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonGecms_Click(object sender, EventArgs e)
        {
            UykuGecmis uykuGecmis = new UykuGecmis();
            uykuGecmis.Show();
            this.Hide();
        }

        private void labelSure_Click(object sender, EventArgs e)
        {

        }
    }
}
