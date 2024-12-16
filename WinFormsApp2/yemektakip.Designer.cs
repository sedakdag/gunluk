namespace WinFormsApp2
{
    partial class yemektakip
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            labelAperatif = new Label();
            labelAksamYemegi = new Label();
            labelOgleYemegi = new Label();
            labelKahvalti = new Label();
            btnAperatifEkle = new Button();
            btnAksamYemegiEkle = new Button();
            btnOgleYemegiEkle = new Button();
            btnKahvaltiEkle = new Button();
            groupBox2 = new GroupBox();
            listBoxYemekler = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LavenderBlush;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(labelAperatif);
            groupBox1.Controls.Add(labelAksamYemegi);
            groupBox1.Controls.Add(labelOgleYemegi);
            groupBox1.Controls.Add(labelKahvalti);
            groupBox1.Controls.Add(btnAperatifEkle);
            groupBox1.Controls.Add(btnAksamYemegiEkle);
            groupBox1.Controls.Add(btnOgleYemegiEkle);
            groupBox1.Controls.Add(btnKahvaltiEkle);
            groupBox1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(402, 371);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yemek Günlüğüm";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 307);
            label4.Name = "label4";
            label4.Size = new Size(90, 30);
            label4.TabIndex = 9;
            label4.Text = "Aperatif";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 223);
            label3.Name = "label3";
            label3.Size = new Size(152, 30);
            label3.TabIndex = 9;
            label3.Text = "Akşam Yemeği";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 144);
            label2.Name = "label2";
            label2.Size = new Size(133, 30);
            label2.TabIndex = 9;
            label2.Text = "Öğle Yemeği";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 68);
            label1.Name = "label1";
            label1.Size = new Size(89, 30);
            label1.TabIndex = 9;
            label1.Text = "Kahvaltı";
            label1.Click += label1_Click_1;
            // 
            // labelAperatif
            // 
            labelAperatif.AutoSize = true;
            labelAperatif.BackColor = Color.Pink;
            labelAperatif.Location = new Point(164, 257);
            labelAperatif.Name = "labelAperatif";
            labelAperatif.Size = new Size(0, 30);
            labelAperatif.TabIndex = 8;
            // 
            // labelAksamYemegi
            // 
            labelAksamYemegi.AutoSize = true;
            labelAksamYemegi.BackColor = Color.Pink;
            labelAksamYemegi.Location = new Point(164, 195);
            labelAksamYemegi.Name = "labelAksamYemegi";
            labelAksamYemegi.Size = new Size(0, 30);
            labelAksamYemegi.TabIndex = 7;
            // 
            // labelOgleYemegi
            // 
            labelOgleYemegi.AutoSize = true;
            labelOgleYemegi.BackColor = Color.Pink;
            labelOgleYemegi.Location = new Point(164, 133);
            labelOgleYemegi.Name = "labelOgleYemegi";
            labelOgleYemegi.Size = new Size(0, 30);
            labelOgleYemegi.TabIndex = 6;
            // 
            // labelKahvalti
            // 
            labelKahvalti.AutoSize = true;
            labelKahvalti.Location = new Point(248, 76);
            labelKahvalti.Name = "labelKahvalti";
            labelKahvalti.Size = new Size(0, 30);
            labelKahvalti.TabIndex = 5;
            // 
            // btnAperatifEkle
            // 
            btnAperatifEkle.BackColor = Color.Pink;
            btnAperatifEkle.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            btnAperatifEkle.Location = new Point(208, 299);
            btnAperatifEkle.Name = "btnAperatifEkle";
            btnAperatifEkle.Size = new Size(91, 38);
            btnAperatifEkle.TabIndex = 4;
            btnAperatifEkle.Text = "Öğe Ekle";
            btnAperatifEkle.UseVisualStyleBackColor = false;
            btnAperatifEkle.Click += btnAperatifEkle_Click;
            // 
            // btnAksamYemegiEkle
            // 
            btnAksamYemegiEkle.BackColor = Color.Pink;
            btnAksamYemegiEkle.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            btnAksamYemegiEkle.Location = new Point(210, 221);
            btnAksamYemegiEkle.Name = "btnAksamYemegiEkle";
            btnAksamYemegiEkle.Size = new Size(90, 40);
            btnAksamYemegiEkle.TabIndex = 3;
            btnAksamYemegiEkle.Text = "Öğe Ekle";
            btnAksamYemegiEkle.UseVisualStyleBackColor = false;
            btnAksamYemegiEkle.Click += btnAksamYemegiEkle_Click;
            // 
            // btnOgleYemegiEkle
            // 
            btnOgleYemegiEkle.BackColor = Color.Pink;
            btnOgleYemegiEkle.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            btnOgleYemegiEkle.Location = new Point(209, 142);
            btnOgleYemegiEkle.Name = "btnOgleYemegiEkle";
            btnOgleYemegiEkle.Size = new Size(90, 40);
            btnOgleYemegiEkle.TabIndex = 2;
            btnOgleYemegiEkle.Text = "Öğe Ekle";
            btnOgleYemegiEkle.UseVisualStyleBackColor = false;
            btnOgleYemegiEkle.Click += btnOgleYemegiEkle_Click;
            // 
            // btnKahvaltiEkle
            // 
            btnKahvaltiEkle.BackColor = Color.Pink;
            btnKahvaltiEkle.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            btnKahvaltiEkle.Location = new Point(209, 66);
            btnKahvaltiEkle.Name = "btnKahvaltiEkle";
            btnKahvaltiEkle.Size = new Size(91, 40);
            btnKahvaltiEkle.TabIndex = 1;
            btnKahvaltiEkle.Text = "Öğe Ekle";
            btnKahvaltiEkle.UseVisualStyleBackColor = false;
            btnKahvaltiEkle.Click += btnKahvaltiEkle_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBoxYemekler);
            groupBox2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(441, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 371);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tüm Gün Ne Yedim?";
            // 
            // listBoxYemekler
            // 
            listBoxYemekler.FormattingEnabled = true;
            listBoxYemekler.ItemHeight = 21;
            listBoxYemekler.Location = new Point(19, 66);
            listBoxYemekler.Name = "listBoxYemekler";
            listBoxYemekler.Size = new Size(160, 256);
            listBoxYemekler.TabIndex = 0;
            // 
            // yemektakip
            // 
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(668, 425);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "yemektakip";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yemek Takip";
            Load += yemektakip_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKahvaltiEkle;
        private System.Windows.Forms.Button btnOgleYemegiEkle;
        private System.Windows.Forms.Button btnAksamYemegiEkle;
        private System.Windows.Forms.Button btnAperatifEkle;
        private System.Windows.Forms.Label labelKahvalti;
        private System.Windows.Forms.Label labelOgleYemegi;
        private System.Windows.Forms.Label labelAksamYemegi;
        private System.Windows.Forms.Label labelAperatif;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxYemekler;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}