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
    public partial class IlacTakibi : Form
    {
        public IlacTakibi()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonKayt_Click(object sender, EventArgs e)
        {
            string ilacIsmi = textBoxIlacIsmi.Text;
            DateTime alisTarihi = dtpIlac.Value;
            string alisZamaniSekli = GetSecilenZaman();

            if (!string.IsNullOrEmpty(ilacIsmi) && alisTarihi != null)
            {
                // ListViewItem oluştur
                ListViewItem item = new ListViewItem(ilacIsmi); // Ana sütun: İlaç İsmi
                item.SubItems.Add(alisTarihi.ToShortDateString()); // Alt sütun: Tarih
                item.SubItems.Add(alisZamaniSekli); // Alt sütun: Zaman ve Şekil

                listViewIlaclar.Items.Add(item);

                //Sonraki ilaç için textbox'u temizle
                textBoxIlacIsmi.Clear();
                dtpIlac.Value = DateTime.Now;

                // RadioButton seçimlerini temizle
                radioButtonAc.Checked = false;
                radioButtonTok.Checked = false;
                radioButtonSabah.Checked = false;
                radioButtonAksam.Checked = false;

            }
            else
            {
                MessageBox.Show("Boş alan bırakmayın!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string GetSecilenZaman()
        {
            string acTokSecimi = "";
            string sabahAksamSecimi = "";

            // Aç/Tok seçimini kontrol eder
            if (radioButtonAc.Checked)
            {
                acTokSecimi = "Aç";
            }
            else if (radioButtonTok.Checked)
            {
                acTokSecimi = "Tok";
            }

            // Sabah/Akşam seçimini kontrol eder
            if (radioButtonSabah.Checked)
            {
                sabahAksamSecimi = "Sabah";
            }
            else if (radioButtonAksam.Checked)
            {
                sabahAksamSecimi = "Akşam";
            }
           
            // İki gruptan seçim yapılmışsa birleştirir
            if (!string.IsNullOrEmpty(acTokSecimi) && !string.IsNullOrEmpty(sabahAksamSecimi))
            {
                return $"{sabahAksamSecimi} - {acTokSecimi}";
            }
            else
            {
                // Eğer seçim eksikse
                return "Eksik seçim!";
            }

        }

        private void radioButtonSabah_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonAksam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonAc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonTok_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxSabahAksam_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxAcTok_Enter(object sender, EventArgs e)
        {

        }
    }
}
