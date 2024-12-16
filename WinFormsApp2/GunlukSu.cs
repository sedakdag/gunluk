using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class GunlukSu : Form
    {
        private int toplamSuMiktari = 0;
        private int hedefSuMiktari = 0;
        public GunlukSu()
        {
            InitializeComponent();
        }

        private void GunlukSu_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            labelIcilenSuInt.Text = $"{toplamSuMiktari} ml";

            if (toplamSuMiktari >= hedefSuMiktari)
            {
                MessageBox.Show("Tebrikler! Günlük su ihtiyacınızı karşıladınız.");
            }
        }

        private void trackbarSu_Scroll(object sender, EventArgs e)
        {
            toplamSuMiktari = trackbarSu.Value * 250;
        }

        private void numericUpDownHedef_ValueChanged(object sender, EventArgs e)
        {
            hedefSuMiktari = (int)numericUpDownHedef.Value * 250; // 1 bardak = 250 ml
            trackbarSu.Maximum = hedefSuMiktari / 250; // TrackBar maksimum değeri güncelle
            trackbarSu.Value = toplamSuMiktari / 250;   // Başlangıç değeri
        }

        private void buttonDegistir_Click(object sender, EventArgs e)
        {

            toplamSuMiktari = 0;
            numericUpDownHedef.Value = 1;
            labelIcilenSuInt.Text = "0 ml";

            trackbarSu.Value = trackbarSu.Minimum;
            trackbarSu.Minimum = 0;
            trackbarSu.Maximum = 1;

            MessageBox.Show("Yeni bir hedef belirleyin.");
        }

        private void labelIcilenSuInt_Click(object sender, EventArgs e)
        {
  
        }
    }
}
