using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WinFormsApp2.MODEL;

namespace WinFormsApp2
{
    public partial class GirisKayit : Form
    {
        List<Kisi> Kisilerim = new List<Kisi>();
        string filePath = "kullaniciBilgileri.txt";

        public GirisKayit()
        {
            InitializeComponent();
        }

        private void buttongrs_Click_1(object sender, EventArgs e)
        {
            string kullan�c�adi = textBoxkullanici.Text;
            int sifre;

            if (int.TryParse(textBoxsifre.Text, out sifre))
            {
                foreach (Kisi Kisi in Kisilerim)
                {
                    if (kullan�c�adi.ToLower() == Kisi.GetKullaniciAdi() && sifre == Kisi.GetSifre())
                    {
                        GirisSayfasi girisSayfasi = new GirisSayfasi();
                        girisSayfasi.Show();
                        this.Hide();
                        return;
                    }
                }

                // Txt dosyas�ndan kontrol et
                if (ValidateLogin(kullan�c�adi, sifre))
                {
                    GirisSayfasi girisSayfasi = new GirisSayfasi();
                    girisSayfasi.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullan�c� ad� veya �ifre hatal�!");
                }
            }
            else
            {
                MessageBox.Show("L�tfen ge�erli bir �ifre giriniz!");
            }
        }


        private void buttonkyt_Click(object sender, EventArgs e)
        {
            // Yeni bir Form3 �rne�i olu�tur
            kayitol form3 = new kayitol();

            // Formu g�ster ve sonucu kontrol et
            if (form3.ShowDialog() == DialogResult.OK)
            {
                // Kullan�c� bilgilerini al
                string ad = form3.Ad;
                string soyad = form3.Soyad;
                string email = form3.Email;
                string kullaniciAdi = form3.KullaniciAdi;
                int sifre = form3.Sifre;

                // Kullan�c� ad� tekrar kontrol�
                if (Kisilerim.Exists(k => k.GetKullaniciAdi() == kullaniciAdi))
                {
                    MessageBox.Show("Bu kullan�c� ad� zaten kay�tl�!");
                    return;
                }

                // Yeni kullan�c�y� ekle
                Kisilerim.Add(new Kisi(Kisilerim.Count + 1, kullaniciAdi, sifre, email));
                File.AppendAllText(filePath, $"{kullaniciAdi};{sifre}{Environment.NewLine}");
                MessageBox.Show("Kay�t ba�ar�yla tamamland�!");
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            // �nceden tan�ml� kullan�c�lar
            Kisilerim.Add(new Kisi(1, "s�la", 123, "sila@gmail.com"));
            Kisilerim.Add(new Kisi(2, "seda", 456, "seda@gmail.com"));
            Kisilerim.Add(new Kisi(3, "dilara", 789, "dilara@gmail.com"));
            Kisilerim.Add(new Kisi(4, "yaprak", 101, "yaprak@gmail.com"));

            // Txt dosyas�ndan kullan�c�lar� y�kle
            LoadUsersFromFile();
        }

        private void LoadUsersFromFile()
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var data = line.Split(';');
                    if (data.Length == 2)
                    {
                        string username = data[0];
                        if (int.TryParse(data[1], out int password))
                        {
                            Kisilerim.Add(new Kisi(Kisilerim.Count + 1, username, password, ""));
                        }
                    }
                }
            }
        }

        private bool CheckIfUserExists(string username)
        {
            if (!File.Exists(filePath)) return false;

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var data = line.Split(';');
                if (data[0].ToLower() == username.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        private bool ValidateLogin(string username, int password)
        {
            if (!File.Exists(filePath)) return false;

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var data = line.Split(';');
                if (data[0].ToLower() == username.ToLower() && int.TryParse(data[1], out int storedPassword) && storedPassword == password)
                {
                    return true;
                }
            }
            return false;
        }

        private void buttonKyt_Click_1(object sender, EventArgs e)
        {
            // Yeni bir Form3 �rne�i olu�tur
            kayitol form3 = new kayitol();

            // Formu g�ster ve sonucu kontrol et
            if (form3.ShowDialog() == DialogResult.OK)
            {
                // Kullan�c� bilgilerini al
                string ad = form3.Ad;
                string soyad = form3.Soyad;
                string email = form3.Email;
                string kullaniciAdi = form3.KullaniciAdi;
                int sifre = form3.Sifre;

                // Kullan�c� ad� tekrar kontrol�
                if (Kisilerim.Exists(k => k.GetKullaniciAdi() == kullaniciAdi))
                {
                    MessageBox.Show("Bu kullan�c� ad� zaten kay�tl�!");
                    return;
                }

                // Yeni kullan�c�y� ekle
                Kisilerim.Add(new Kisi(Kisilerim.Count + 1, kullaniciAdi, sifre, email));
                File.AppendAllText(filePath, $"{kullaniciAdi};{sifre}{Environment.NewLine}");
                MessageBox.Show("Kay�t ba�ar�yla tamamland�!");
            }
        }
    }
}
