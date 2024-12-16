using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class todolist : Form
    {
        // Yapılacaklar ve Tamamlananlar panelleri
        Panel panelYapilacaklar;
        Panel panelTamamlananlar;
        int yapilacaklarY = 10; // Yapılacaklar için başlangıç y değeri
        int tamamlananlarY = 10; // Tamamlananlar için başlangıç y değeri
        int toplamGorevSayisi = 0; // Toplam eklenen görev sayısı
        int tamamlananGorevSayisi = 0; // Tamamlanan görev sayısı


        // Görev ekleme butonu
        Button btnGorevEkle;

        public todolist()
        {
            InitializeComponent();
            InitializeFormComponents();
        }

        private void InitializeFormComponents()
        {
            // Form Ayarları
            this.Text = "ToDo List";
            this.Size = new Size(600, 450);
            this.BackColor = Color.LavenderBlush;

            // Yapılacaklar Paneli
            panelYapilacaklar = new Panel
            {
                Location = new Point(50, 100),
                Size = new Size(200, 250),
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(panelYapilacaklar);

            // Tamamlananlar Paneli
            panelTamamlananlar = new Panel
            {
                Location = new Point(300, 100),
                Size = new Size(200, 250),
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(panelTamamlananlar);

            // Görev Ekle Butonu
            btnGorevEkle = new Button
            {
                Text = "GÖREV EKLE",
                Font = new Font("Arial", 10, FontStyle.Bold),
                Location = new Point(50, 355),
                Size = new Size(200, 30),
                BackColor = Color.LightPink
            };
            btnGorevEkle.Click += btnGorevEkle_Click;
            this.Controls.Add(btnGorevEkle);

            // Başlıklar
            Label lblYapilacaklar = new Label
            {
                Text = "YAPILACAKLAR",
                Location = new Point(50, 80),
                Font = new Font("Arial", 10, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true // Otomatik genişlik ayarı
            };
            this.Controls.Add(lblYapilacaklar);

            Label lblTamamlananlar = new Label
            {
                Text = "TAMAMLANANLAR",
                Location = new Point(300, 80),
                Font = new Font("Arial", 10, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true // Otomatik genişlik ayarı
            };
            this.Controls.Add(lblTamamlananlar);
        }



        private void btnGorevEkle_Click(object sender, EventArgs e)
        {
            string gorevMetni = Microsoft.VisualBasic.Interaction.InputBox(
                "Lütfen görevi girin:", "Görev Ekle", "Yeni Görev");

            if (!string.IsNullOrWhiteSpace(gorevMetni))
            {
                CheckBox cbGorev = new CheckBox();
                cbGorev.Text = gorevMetni;
                cbGorev.AutoSize = true;
                cbGorev.Location = new Point(10, yapilacaklarY);
                cbGorev.CheckedChanged += CbGorev_CheckedChanged;

                panelYapilacaklar.Controls.Add(cbGorev);

                yapilacaklarY += 25;
                toplamGorevSayisi++; // Toplam görev sayısını artır
            }
        }



        private void CbGorev_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            if (cb != null && cb.Checked)
            {
                panelYapilacaklar.Controls.Remove(cb);
                cb.Location = new Point(10, tamamlananlarY);
                panelTamamlananlar.Controls.Add(cb);

                tamamlananlarY += 25;
                tamamlananGorevSayisi++; // Tamamlanan görev sayısını artır

                // Tüm görevler tamamlandı mı kontrol et
                if (tamamlananGorevSayisi == toplamGorevSayisi)
                {
                    pictureBox1.Visible = true; // Kutlama GIF'ini göster
                }
            }
        }


    }
}
