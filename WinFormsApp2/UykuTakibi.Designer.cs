namespace WinFormsApp2
{
    partial class UykuTakibi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UykuTakibi));
            dateUykuSaati = new DateTimePicker();
            datetimeUyanmaSaati = new DateTimePicker();
            labelToplam = new Label();
            labelUyku = new Label();
            labelUyanma = new Label();
            buttonHesapla = new Button();
            labelSure = new Label();
            buttonKayit = new Button();
            panel1 = new Panel();
            buttonGecms = new Button();
            listViewGecmis = new ListView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dateUykuSaati
            // 
            dateUykuSaati.Format = DateTimePickerFormat.Time;
            dateUykuSaati.Location = new Point(305, 98);
            dateUykuSaati.Name = "dateUykuSaati";
            dateUykuSaati.Size = new Size(105, 23);
            dateUykuSaati.TabIndex = 0;
            // 
            // datetimeUyanmaSaati
            // 
            datetimeUyanmaSaati.Format = DateTimePickerFormat.Time;
            datetimeUyanmaSaati.Location = new Point(305, 148);
            datetimeUyanmaSaati.Name = "datetimeUyanmaSaati";
            datetimeUyanmaSaati.Size = new Size(105, 23);
            datetimeUyanmaSaati.TabIndex = 1;
            // 
            // labelToplam
            // 
            labelToplam.AutoSize = true;
            labelToplam.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelToplam.Location = new Point(58, 259);
            labelToplam.Name = "labelToplam";
            labelToplam.Size = new Size(190, 25);
            labelToplam.TabIndex = 2;
            labelToplam.Text = "Toplam Uyku Saati:";
            // 
            // labelUyku
            // 
            labelUyku.AutoSize = true;
            labelUyku.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUyku.Location = new Point(101, 96);
            labelUyku.Name = "labelUyku";
            labelUyku.Size = new Size(149, 25);
            labelUyku.TabIndex = 3;
            labelUyku.Text = "Uykuya Dalma:";
            // 
            // labelUyanma
            // 
            labelUyanma.AutoSize = true;
            labelUyanma.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUyanma.Location = new Point(69, 146);
            labelUyanma.Name = "labelUyanma";
            labelUyanma.Size = new Size(179, 25);
            labelUyanma.TabIndex = 4;
            labelUyanma.Text = "Uykudan Uyanma:";
            // 
            // buttonHesapla
            // 
            buttonHesapla.BackColor = Color.Silver;
            buttonHesapla.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHesapla.Location = new Point(298, 187);
            buttonHesapla.Name = "buttonHesapla";
            buttonHesapla.Size = new Size(124, 47);
            buttonHesapla.TabIndex = 5;
            buttonHesapla.Text = "Hesapla";
            buttonHesapla.UseVisualStyleBackColor = false;
            buttonHesapla.Click += buttonHesapla_Click;
            // 
            // labelSure
            // 
            labelSure.AutoSize = true;
            labelSure.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSure.Location = new Point(254, 259);
            labelSure.Name = "labelSure";
            labelSure.Size = new Size(23, 25);
            labelSure.TabIndex = 6;
            labelSure.Text = "0";
            labelSure.Click += labelSure_Click;
            // 
            // buttonKayit
            // 
            buttonKayit.BackColor = Color.Silver;
            buttonKayit.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKayit.Location = new Point(91, 294);
            buttonKayit.Name = "buttonKayit";
            buttonKayit.Size = new Size(124, 47);
            buttonKayit.TabIndex = 7;
            buttonKayit.Text = "Kaydet";
            buttonKayit.UseVisualStyleBackColor = false;
            buttonKayit.Click += buttonKayit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(557, 80);
            panel1.TabIndex = 8;
            // 
            // buttonGecms
            // 
            buttonGecms.BackColor = Color.Silver;
            buttonGecms.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGecms.Location = new Point(372, 294);
            buttonGecms.Name = "buttonGecms";
            buttonGecms.Size = new Size(124, 47);
            buttonGecms.TabIndex = 9;
            buttonGecms.Text = "Geçmiş";
            buttonGecms.UseVisualStyleBackColor = false;
            buttonGecms.Click += buttonGecms_Click;
            // 
            // listViewGecmis
            // 
            listViewGecmis.Location = new Point(547, 355);
            listViewGecmis.Name = "listViewGecmis";
            listViewGecmis.Size = new Size(10, 10);
            listViewGecmis.TabIndex = 10;
            listViewGecmis.UseCompatibleStateImageBehavior = false;
            listViewGecmis.View = View.Tile;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(114, 178);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(173, 27);
            label1.Name = "label1";
            label1.Size = new Size(194, 33);
            label1.TabIndex = 12;
            label1.Text = "Uyku Rutinim";
            // 
            // UykuTakibi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(558, 361);
            Controls.Add(pictureBox1);
            Controls.Add(listViewGecmis);
            Controls.Add(buttonGecms);
            Controls.Add(panel1);
            Controls.Add(buttonKayit);
            Controls.Add(labelSure);
            Controls.Add(buttonHesapla);
            Controls.Add(labelUyanma);
            Controls.Add(labelUyku);
            Controls.Add(labelToplam);
            Controls.Add(datetimeUyanmaSaati);
            Controls.Add(dateUykuSaati);
            Name = "UykuTakibi";
            Text = "UykuTakibi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateUykuSaati;
        private DateTimePicker datetimeUyanmaSaati;
        private Label labelToplam;
        private Label labelUyku;
        private Label labelUyanma;
        private Button buttonHesapla;
        private Label labelSure;
        private Button buttonKayit;
        private Panel panel1;
        private Button buttonGecms;
        private ListView listViewGecmis;
        private Label label1;
        private PictureBox pictureBox1;
    }
}