namespace FitnessEgzersizApp
{
    partial class FitnessForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Temizleme işlemlerini yapar.
        /// </summary>
        /// <param name="disposing">Yönetilen kaynakların silinip silinmeyeceğini belirtir.</param>
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
        /// Designer tarafından oluşturulan bileşenleri tanımlar.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtEgzersizAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numTekrarSayisi = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numSure = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.listBoxEgzersizler = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToplamSure = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTekrarSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSure)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Egzersiz Adı:";
            // 
            // txtEgzersizAdi
            // 
            this.txtEgzersizAdi.Location = new System.Drawing.Point(150, 27);
            this.txtEgzersizAdi.Name = "txtEgzersizAdi";
            this.txtEgzersizAdi.Size = new System.Drawing.Size(150, 23);
            this.txtEgzersizAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tekrar Sayısı:";
            // 
            // numTekrarSayisi
            // 
            this.numTekrarSayisi.Location = new System.Drawing.Point(150, 68);
            this.numTekrarSayisi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numTekrarSayisi.Name = "numTekrarSayisi";
            this.numTekrarSayisi.Size = new System.Drawing.Size(60, 23);
            this.numTekrarSayisi.TabIndex = 3;
            this.numTekrarSayisi.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Süre (dk):";
            // 
            // numSure
            // 
            this.numSure.Location = new System.Drawing.Point(150, 108);
            this.numSure.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSure.Name = "numSure";
            this.numSure.Size = new System.Drawing.Size(60, 23);
            this.numSure.TabIndex = 5;
            this.numSure.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(150, 150);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 30);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // listBoxEgzersizler
            // 
            this.listBoxEgzersizler.FormattingEnabled = true;
            this.listBoxEgzersizler.ItemHeight = 15;
            this.listBoxEgzersizler.Location = new System.Drawing.Point(30, 200);
            this.listBoxEgzersizler.Name = "listBoxEgzersizler";
            this.listBoxEgzersizler.Size = new System.Drawing.Size(300, 150);
            this.listBoxEgzersizler.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Toplam Süre:";
            // 
            // txtToplamSure
            // 
            this.txtToplamSure.Location = new System.Drawing.Point(150, 367);
            this.txtToplamSure.Name = "txtToplamSure";
            this.txtToplamSure.ReadOnly = true;
            this.txtToplamSure.Size = new System.Drawing.Size(100, 23);
            this.txtToplamSure.TabIndex = 9;
            // 
            // FitnessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.txtToplamSure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxEgzersizler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.numSure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numTekrarSayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEgzersizAdi);
            this.Controls.Add(this.label1);
            this.Name = "FitnessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fitness Egzersiz Takibi";
            ((System.ComponentModel.ISupportInitialize)(this.numTekrarSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEgzersizAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numTekrarSayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numSure;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox listBoxEgzersizler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToplamSure;
    }
}
