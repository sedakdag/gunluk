using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class GununSarkisi : Form
    {
        public GununSarkisi()
        {
            InitializeComponent();
        }

        private async void webView21_Click(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async(null);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textboxSarkiIsmi_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            string sarkiAdi = textboxSarkiIsmi.Text;

            if (string.IsNullOrEmpty(sarkiAdi)) { 
                MessageBox.Show("Lütfen bir şarkı adı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string spotifySearchURL = "https://open.spotify.com/search/" + HttpUtility.UrlEncode(sarkiAdi); ; //Spotify arama URL'si oluşturur
            webView21.Source = new Uri(spotifySearchURL); //WebView2 kullanarak bu URL'yi gösterir
        }
    }
}
