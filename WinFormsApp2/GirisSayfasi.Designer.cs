namespace WinFormsApp2
{
    partial class GirisSayfasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            sekmeGezgini = new Label();
            buttonGunlukGirdileri = new Button();
            buttonGununSozu = new Button();
            buttonToDoList = new Button();
            buttonGunlukSuIcme = new Button();
            buttonGununSarkisi = new Button();
            buttonYemekTakibi = new Button();
            buttonUykuTakibi = new Button();
            buttonFitnessveEgzersizTakibi = new Button();
            buttonProfiliDuzenle = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(sekmeGezgini);
            panel1.Location = new Point(1, -2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(617, 87);
            panel1.TabIndex = 0;
            // 
            // sekmeGezgini
            // 
            sekmeGezgini.AutoSize = true;
            sekmeGezgini.Font = new Font("Constantia", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            sekmeGezgini.ForeColor = Color.FromArgb(255, 128, 128);
            sekmeGezgini.Location = new Point(164, 26);
            sekmeGezgini.Margin = new Padding(2, 0, 2, 0);
            sekmeGezgini.Name = "sekmeGezgini";
            sekmeGezgini.Size = new Size(258, 42);
            sekmeGezgini.TabIndex = 0;
            sekmeGezgini.Text = "Sekme Gezgini";
            // 
            // buttonGunlukGirdileri
            // 
            buttonGunlukGirdileri.Font = new Font("Calibri", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonGunlukGirdileri.Location = new Point(166, 97);
            buttonGunlukGirdileri.Margin = new Padding(2);
            buttonGunlukGirdileri.Name = "buttonGunlukGirdileri";
            buttonGunlukGirdileri.Size = new Size(270, 52);
            buttonGunlukGirdileri.TabIndex = 1;
            buttonGunlukGirdileri.Text = "Günlük Girdileri";
            buttonGunlukGirdileri.UseVisualStyleBackColor = true;
            buttonGunlukGirdileri.Click += buttonGunlukGirdileri_Click;
            // 
            // buttonGununSozu
            // 
            buttonGununSozu.Font = new Font("Calibri", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonGununSozu.Location = new Point(166, 160);
            buttonGununSozu.Margin = new Padding(2);
            buttonGununSozu.Name = "buttonGununSozu";
            buttonGununSozu.Size = new Size(270, 52);
            buttonGununSozu.TabIndex = 2;
            buttonGununSozu.Text = "Günün Sözü";
            buttonGununSozu.UseVisualStyleBackColor = true;
            buttonGununSozu.Click += buttonGununSozu_Click;
            // 
            // buttonToDoList
            // 
            buttonToDoList.Font = new Font("Calibri", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonToDoList.Location = new Point(166, 222);
            buttonToDoList.Margin = new Padding(2);
            buttonToDoList.Name = "buttonToDoList";
            buttonToDoList.Size = new Size(270, 52);
            buttonToDoList.TabIndex = 3;
            buttonToDoList.Text = "To-Do List";
            buttonToDoList.UseVisualStyleBackColor = true;
            buttonToDoList.Click += buttonToDoList_Click;
            // 
            // buttonGunlukSuIcme
            // 
            buttonGunlukSuIcme.Font = new Font("Calibri", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonGunlukSuIcme.Location = new Point(166, 286);
            buttonGunlukSuIcme.Margin = new Padding(2);
            buttonGunlukSuIcme.Name = "buttonGunlukSuIcme";
            buttonGunlukSuIcme.Size = new Size(270, 52);
            buttonGunlukSuIcme.TabIndex = 4;
            buttonGunlukSuIcme.Text = "Günlük Su İçme Kaydı";
            buttonGunlukSuIcme.UseVisualStyleBackColor = true;
            buttonGunlukSuIcme.Click += buttonGunlukSuIcme_Click;
            // 
            // buttonGununSarkisi
            // 
            buttonGununSarkisi.Font = new Font("Calibri", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonGununSarkisi.Location = new Point(166, 350);
            buttonGununSarkisi.Margin = new Padding(2);
            buttonGununSarkisi.Name = "buttonGununSarkisi";
            buttonGununSarkisi.Size = new Size(270, 52);
            buttonGununSarkisi.TabIndex = 5;
            buttonGununSarkisi.Text = "Günün Şarkısı";
            buttonGununSarkisi.UseVisualStyleBackColor = true;
            buttonGununSarkisi.Click += buttonGununSarkisi_Click;
            // 
            // buttonYemekTakibi
            // 
            buttonYemekTakibi.Font = new Font("Calibri", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonYemekTakibi.Location = new Point(166, 413);
            buttonYemekTakibi.Margin = new Padding(2);
            buttonYemekTakibi.Name = "buttonYemekTakibi";
            buttonYemekTakibi.Size = new Size(270, 52);
            buttonYemekTakibi.TabIndex = 6;
            buttonYemekTakibi.Text = "Yemek Takibi";
            buttonYemekTakibi.UseVisualStyleBackColor = true;
            buttonYemekTakibi.Click += buttonYemekTakibi_Click;
            // 
            // buttonUykuTakibi
            // 
            buttonUykuTakibi.Font = new Font("Calibri", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonUykuTakibi.Location = new Point(166, 475);
            buttonUykuTakibi.Margin = new Padding(2);
            buttonUykuTakibi.Name = "buttonUykuTakibi";
            buttonUykuTakibi.Size = new Size(270, 52);
            buttonUykuTakibi.TabIndex = 7;
            buttonUykuTakibi.Text = "Uyku Takibi";
            buttonUykuTakibi.UseVisualStyleBackColor = true;
            buttonUykuTakibi.Click += buttonUykuTakibi_Click;
            // 
            // buttonFitnessveEgzersizTakibi
            // 
            buttonFitnessveEgzersizTakibi.Font = new Font("Calibri", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonFitnessveEgzersizTakibi.Location = new Point(166, 538);
            buttonFitnessveEgzersizTakibi.Margin = new Padding(2);
            buttonFitnessveEgzersizTakibi.Name = "buttonFitnessveEgzersizTakibi";
            buttonFitnessveEgzersizTakibi.Size = new Size(270, 52);
            buttonFitnessveEgzersizTakibi.TabIndex = 8;
            buttonFitnessveEgzersizTakibi.Text = "Fitness ve Egzersiz Takibi";
            buttonFitnessveEgzersizTakibi.UseVisualStyleBackColor = true;
            buttonFitnessveEgzersizTakibi.Click += buttonFitnessveEgzersizTakibi_Click;
            // 
            // buttonProfiliDuzenle
            // 
            buttonProfiliDuzenle.Font = new Font("Calibri", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonProfiliDuzenle.Location = new Point(166, 601);
            buttonProfiliDuzenle.Margin = new Padding(2);
            buttonProfiliDuzenle.Name = "buttonProfiliDuzenle";
            buttonProfiliDuzenle.Size = new Size(270, 52);
            buttonProfiliDuzenle.TabIndex = 9;
            buttonProfiliDuzenle.Text = "Profili Düzenle";
            buttonProfiliDuzenle.UseVisualStyleBackColor = true;
            buttonProfiliDuzenle.Click += buttonProfiliDuzenle_Click;
            // 
            // GirisSayfasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(613, 717);
            Controls.Add(buttonProfiliDuzenle);
            Controls.Add(buttonFitnessveEgzersizTakibi);
            Controls.Add(buttonUykuTakibi);
            Controls.Add(buttonYemekTakibi);
            Controls.Add(buttonGununSarkisi);
            Controls.Add(buttonGunlukSuIcme);
            Controls.Add(buttonToDoList);
            Controls.Add(buttonGununSozu);
            Controls.Add(buttonGunlukGirdileri);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "GirisSayfasi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GirisSayfasi";
            Load += GirisSayfasi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label sekmeGezgini;
        private Button buttonGunlukGirdileri;
        private Button buttonGununSozu;
        private Button buttonToDoList;
        private Button buttonGunlukSuIcme;
        private Button buttonGununSarkisi;
        private Button buttonYemekTakibi;
        private Button buttonUykuTakibi;
        private Button buttonFitnessveEgzersizTakibi;
        private Button buttonProfiliDuzenle;
    }
}