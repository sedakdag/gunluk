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
            string alisZamani = GetVakit();
            string alisSekli = GetAlisSekli();

            if (!string.IsNullOrEmpty(ilacIsmi) && alisTarihi != null) { 
                ListViewItem item = new ListViewItem(new[] {ilacIsmi, alisTarihi.ToShortDateString(), alisZamani, alisSekli});
                listViewIlaclar.Items.Add(item);

                //Sonraki ilaç için textbox'u temizle
                textBoxIlacIsmi.Clear();
                dtpIlac.Value = DateTime.Now;

            }
        }

        private string GetVakit()
        {
            if (radioButtonSabah.Checked) return "Sabah";
            if (radioButtonOgle.Checked) return "Öğle";
            if (radioButtonAksam.Checked) return "Akşam";
            return string.Empty;
        }

        private string GetAlisSekli()
        {
            if (radioButtonAc.Checked) return "Aç";
            if (radioButtonTok.Checked) return "Tok";
            return string.Empty;
        }

        private void radioButtonSabah_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonOgle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonAksam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonTok_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
