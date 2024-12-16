namespace WinFormsApp2
{
    partial class GunlukSu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GunlukSu));
            dateTimePickerSu = new DateTimePicker();
            trackbarSu = new TrackBar();
            panelMavi = new Panel();
            buttonGuncelle = new Button();
            numericUpDownHedef = new NumericUpDown();
            labelHedefSec = new Label();
            labelIcilenSu = new Label();
            labelIcilenSuInt = new Label();
            buttonDegistir = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)trackbarSu).BeginInit();
            panelMavi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHedef).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePickerSu
            // 
            dateTimePickerSu.Location = new Point(12, 12);
            dateTimePickerSu.Name = "dateTimePickerSu";
            dateTimePickerSu.Size = new Size(200, 23);
            dateTimePickerSu.TabIndex = 0;
            // 
            // trackbarSu
            // 
            trackbarSu.BackColor = Color.White;
            trackbarSu.Location = new Point(65, 35);
            trackbarSu.Maximum = 1;
            trackbarSu.Name = "trackbarSu";
            trackbarSu.Size = new Size(412, 45);
            trackbarSu.TabIndex = 1;
            trackbarSu.Scroll += trackbarSu_Scroll;
            // 
            // panelMavi
            // 
            panelMavi.BackColor = Color.PowderBlue;
            panelMavi.Controls.Add(trackbarSu);
            panelMavi.Location = new Point(-4, 193);
            panelMavi.Name = "panelMavi";
            panelMavi.Size = new Size(533, 117);
            panelMavi.TabIndex = 2;
            // 
            // buttonGuncelle
            // 
            buttonGuncelle.BackColor = Color.Gray;
            buttonGuncelle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGuncelle.Location = new Point(352, 351);
            buttonGuncelle.Name = "buttonGuncelle";
            buttonGuncelle.Size = new Size(143, 47);
            buttonGuncelle.TabIndex = 3;
            buttonGuncelle.Text = "Güncelle";
            buttonGuncelle.UseVisualStyleBackColor = false;
            buttonGuncelle.Click += buttonGuncelle_Click;
            // 
            // numericUpDownHedef
            // 
            numericUpDownHedef.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownHedef.Location = new Point(296, 70);
            numericUpDownHedef.Name = "numericUpDownHedef";
            numericUpDownHedef.Size = new Size(90, 29);
            numericUpDownHedef.TabIndex = 5;
            numericUpDownHedef.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownHedef.ValueChanged += numericUpDownHedef_ValueChanged;
            // 
            // labelHedefSec
            // 
            labelHedefSec.AutoSize = true;
            labelHedefSec.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHedefSec.Location = new Point(37, 70);
            labelHedefSec.Name = "labelHedefSec";
            labelHedefSec.Size = new Size(253, 25);
            labelHedefSec.TabIndex = 6;
            labelHedefSec.Text = "Günlük su hedefinizi seçiniz:";
            // 
            // labelIcilenSu
            // 
            labelIcilenSu.AutoSize = true;
            labelIcilenSu.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIcilenSu.Location = new Point(37, 124);
            labelIcilenSu.Name = "labelIcilenSu";
            labelIcilenSu.Size = new Size(175, 25);
            labelIcilenSu.TabIndex = 7;
            labelIcilenSu.Text = "İçtiğiniz su miktarı:";
            // 
            // labelIcilenSuInt
            // 
            labelIcilenSuInt.AutoSize = true;
            labelIcilenSuInt.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIcilenSuInt.Location = new Point(218, 124);
            labelIcilenSuInt.Name = "labelIcilenSuInt";
            labelIcilenSuInt.Size = new Size(50, 25);
            labelIcilenSuInt.TabIndex = 8;
            labelIcilenSuInt.Text = "0 ml";
            labelIcilenSuInt.Click += labelIcilenSuInt_Click;
            // 
            // buttonDegistir
            // 
            buttonDegistir.BackColor = Color.Gray;
            buttonDegistir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDegistir.Location = new Point(37, 351);
            buttonDegistir.Name = "buttonDegistir";
            buttonDegistir.Size = new Size(143, 47);
            buttonDegistir.TabIndex = 4;
            buttonDegistir.Text = "Hedef Değiştir";
            buttonDegistir.UseVisualStyleBackColor = false;
            buttonDegistir.Click += buttonDegistir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(404, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // GunlukSu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(528, 432);
            Controls.Add(pictureBox1);
            Controls.Add(labelIcilenSuInt);
            Controls.Add(labelIcilenSu);
            Controls.Add(labelHedefSec);
            Controls.Add(numericUpDownHedef);
            Controls.Add(buttonDegistir);
            Controls.Add(buttonGuncelle);
            Controls.Add(panelMavi);
            Controls.Add(dateTimePickerSu);
            Name = "GunlukSu";
            Text = "GunlukSu";
            Load += GunlukSu_Load;
            ((System.ComponentModel.ISupportInitialize)trackbarSu).EndInit();
            panelMavi.ResumeLayout(false);
            panelMavi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHedef).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerSu;
        private TrackBar trackbarSu;
        private Panel panelMavi;
        private Button buttonGuncelle;
        private NumericUpDown numericUpDownHedef;
        private Label labelHedefSec;
        private Label labelIcilenSu;
        private Label labelIcilenSuInt;
        private Button buttonDegistir;
        private PictureBox pictureBox1;
    }
}