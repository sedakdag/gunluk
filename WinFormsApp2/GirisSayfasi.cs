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
    public partial class GirisSayfasi : Form
    {
        public GirisSayfasi()
        {
            InitializeComponent();
        }

        private void buttonGunlukGirdileri_Click(object sender, EventArgs e)
        {
            GunlukGirdiler gunlukGirdiler = new GunlukGirdiler();
            gunlukGirdiler.Show();
            this.Hide();
        }

        private void buttonGununSozu_Click(object sender, EventArgs e)
        {
            GununSozu gununSozu = new GununSozu();
            gununSozu.Show();
            this.Hide();
        }

        private void buttonToDoList_Click(object sender, EventArgs e)
        {
            todolist todolist = new todolist();
            todolist.Show();
            this.Hide();
        }

        private void buttonGunlukSuIcme_Click(object sender, EventArgs e)
        {
            GunlukSu gunlukSu = new GunlukSu();
            gunlukSu.Show();
            this.Hide();
        }

        private void buttonGununSarkisi_Click(object sender, EventArgs e)
        {
            GununSarkisi gununSarkisi = new GununSarkisi();
            gununSarkisi.Show();
            this.Hide();
        }

        private void buttonYemekTakibi_Click(object sender, EventArgs e)
        {
            yemektakip _yemekTakibi = new yemektakip();
            _yemekTakibi.Show();
            this.Hide();
        }

        private void buttonUykuTakibi_Click(object sender, EventArgs e)
        {
            UykuTakibi uykuTakibi = new UykuTakibi();
            uykuTakibi.Show();
            this.Hide();
        }

        private void buttonFitnessveEgzersizTakibi_Click(object sender, EventArgs e)
        {
            FitnessEgzersiz _fitnessEgzersiz = new FitnessEgzersiz();
            _fitnessEgzersiz.Show();
            this.Hide();
        }

        private void buttonProfiliDuzenle_Click(object sender, EventArgs e)
        {
            ProfiliDuzenle profiliDuzenle = new ProfiliDuzenle();
            profiliDuzenle.Show();
            this.Hide();
        }

        private void GirisSayfasi_Load(object sender, EventArgs e)
        {

        }
    }
}
