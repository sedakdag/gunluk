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
    public partial class Gecmis : Form
    {
        public Gecmis()
        {
            InitializeComponent();
            LoadGecmisVeriler();
        }
        private void LoadGecmisVeriler()
        {
            string dosyaYolu = "girdiler.txt";
            if (File.Exists(dosyaYolu))
            {
                using (StreamReader sr = new StreamReader(dosyaYolu))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        textboxGecmis.AppendText(line + Environment.NewLine);
                    }
                }
            }
            else
            {
                MessageBox.Show("Henüz günlüğünüz hiç güncellenmemiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textboxGecmis.AppendText("Henüz geçmiş veri bulunmamaktadır." + Environment.NewLine);
                return;
            }
        }
        private void Gecmis_Load(object sender, EventArgs e)
        {
           

        }
    }
}
