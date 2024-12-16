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
    public partial class UykuGecmis : Form
    {
        public UykuGecmis()
        {
            InitializeComponent();
        }

        private void UykuGecmis_Load(object sender, EventArgs e)
        {
            string dosyaYolu = "uyku.txt";
            if (File.Exists(dosyaYolu))
            {
                using (StreamReader sr = new StreamReader(dosyaYolu))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        textBoxUyku.AppendText(line + Environment.NewLine);
                    }
                }
            }
            else
            {
                MessageBox.Show("Henüz uyku takviminiz hiç güncellenmemiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxUyku.AppendText("Henüz geçmiş veri bulunmamaktadır." + Environment.NewLine);
                return;
            }
        }
    }
}
