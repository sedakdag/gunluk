
namespace WinFormsApp2
{
    partial class IlacTakibi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IlacTakibi));
            textBoxIlacIsmi = new TextBox();
            dtpIlac = new DateTimePicker();
            labelIlacIsmi = new Label();
            radioButtonAc = new RadioButton();
            radioButtonTok = new RadioButton();
            labelAcTok = new Label();
            label1 = new Label();
            radioButtonSabah = new RadioButton();
            radioButtonOgle = new RadioButton();
            radioButtonAksam = new RadioButton();
            buttonKayt = new Button();
            listViewIlaclar = new ListView();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxIlacIsmi
            // 
            textBoxIlacIsmi.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxIlacIsmi.Location = new Point(229, 102);
            textBoxIlacIsmi.Name = "textBoxIlacIsmi";
            textBoxIlacIsmi.Size = new Size(140, 29);
            textBoxIlacIsmi.TabIndex = 0;
            textBoxIlacIsmi.TextChanged += textBox1_TextChanged;
            // 
            // dtpIlac
            // 
            dtpIlac.Checked = false;
            dtpIlac.Location = new Point(45, 66);
            dtpIlac.Name = "dtpIlac";
            dtpIlac.Size = new Size(200, 23);
            dtpIlac.TabIndex = 1;
            dtpIlac.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // labelIlacIsmi
            // 
            labelIlacIsmi.AutoSize = true;
            labelIlacIsmi.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIlacIsmi.Location = new Point(45, 106);
            labelIlacIsmi.Name = "labelIlacIsmi";
            labelIlacIsmi.Size = new Size(178, 25);
            labelIlacIsmi.TabIndex = 2;
            labelIlacIsmi.Text = "İlaç İsmini Giriniz:";
            // 
            // radioButtonAc
            // 
            radioButtonAc.AutoSize = true;
            radioButtonAc.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonAc.Location = new Point(137, 152);
            radioButtonAc.Name = "radioButtonAc";
            radioButtonAc.Size = new Size(44, 23);
            radioButtonAc.TabIndex = 3;
            radioButtonAc.TabStop = true;
            radioButtonAc.Text = "Aç";
            radioButtonAc.UseVisualStyleBackColor = true;
            radioButtonAc.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButtonTok
            // 
            radioButtonTok.AutoSize = true;
            radioButtonTok.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonTok.Location = new Point(187, 152);
            radioButtonTok.Name = "radioButtonTok";
            radioButtonTok.Size = new Size(51, 23);
            radioButtonTok.TabIndex = 4;
            radioButtonTok.TabStop = true;
            radioButtonTok.Text = "Tok";
            radioButtonTok.UseVisualStyleBackColor = true;
            radioButtonTok.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // labelAcTok
            // 
            labelAcTok.AutoSize = true;
            labelAcTok.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAcTok.Location = new Point(45, 149);
            labelAcTok.Name = "labelAcTok";
            labelAcTok.Size = new Size(86, 25);
            labelAcTok.TabIndex = 5;
            labelAcTok.Text = "Aç/Tok?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 195);
            label1.Name = "label1";
            label1.Size = new Size(200, 25);
            label1.TabIndex = 6;
            label1.Text = "Sabah/Öğle/Akşam?";
            // 
            // radioButtonSabah
            // 
            radioButtonSabah.AutoSize = true;
            radioButtonSabah.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonSabah.Location = new Point(254, 198);
            radioButtonSabah.Name = "radioButtonSabah";
            radioButtonSabah.Size = new Size(69, 23);
            radioButtonSabah.TabIndex = 7;
            radioButtonSabah.TabStop = true;
            radioButtonSabah.Text = "Sabah";
            radioButtonSabah.UseVisualStyleBackColor = true;
            radioButtonSabah.CheckedChanged += radioButtonSabah_CheckedChanged;
            // 
            // radioButtonOgle
            // 
            radioButtonOgle.AutoSize = true;
            radioButtonOgle.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonOgle.Location = new Point(329, 198);
            radioButtonOgle.Name = "radioButtonOgle";
            radioButtonOgle.Size = new Size(59, 23);
            radioButtonOgle.TabIndex = 8;
            radioButtonOgle.TabStop = true;
            radioButtonOgle.Text = "Öğle";
            radioButtonOgle.UseVisualStyleBackColor = true;
            radioButtonOgle.CheckedChanged += radioButtonOgle_CheckedChanged;
            // 
            // radioButtonAksam
            // 
            radioButtonAksam.AutoSize = true;
            radioButtonAksam.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonAksam.Location = new Point(394, 198);
            radioButtonAksam.Name = "radioButtonAksam";
            radioButtonAksam.Size = new Size(73, 23);
            radioButtonAksam.TabIndex = 9;
            radioButtonAksam.TabStop = true;
            radioButtonAksam.Text = "Akşam";
            radioButtonAksam.UseVisualStyleBackColor = true;
            radioButtonAksam.CheckedChanged += radioButtonAksam_CheckedChanged;
            // 
            // buttonKayt
            // 
            buttonKayt.BackColor = Color.FromArgb(255, 128, 128);
            buttonKayt.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKayt.Location = new Point(198, 234);
            buttonKayt.Name = "buttonKayt";
            buttonKayt.Size = new Size(115, 40);
            buttonKayt.TabIndex = 10;
            buttonKayt.Text = "Kaydet";
            buttonKayt.UseVisualStyleBackColor = false;
            buttonKayt.Click += buttonKayt_Click;
            // 
            // listViewIlaclar
            // 
            listViewIlaclar.Location = new Point(45, 286);
            listViewIlaclar.Name = "listViewIlaclar";
            listViewIlaclar.Size = new Size(422, 152);
            listViewIlaclar.TabIndex = 11;
            listViewIlaclar.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-4, -9);
            panel1.Name = "panel1";
            panel1.Size = new Size(534, 64);
            panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(394, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 128);
            label2.Location = new Point(198, 19);
            label2.Name = "label2";
            label2.Size = new Size(135, 33);
            label2.TabIndex = 0;
            label2.Text = "İlaçlarım";
            // 
            // IlacTakibi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(528, 450);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(listViewIlaclar);
            Controls.Add(buttonKayt);
            Controls.Add(radioButtonAksam);
            Controls.Add(radioButtonOgle);
            Controls.Add(radioButtonSabah);
            Controls.Add(label1);
            Controls.Add(labelAcTok);
            Controls.Add(radioButtonTok);
            Controls.Add(radioButtonAc);
            Controls.Add(labelIlacIsmi);
            Controls.Add(dtpIlac);
            Controls.Add(textBoxIlacIsmi);
            Name = "IlacTakibi";
            Text = "IlacTakibi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox textBoxIlacIsmi;
        private DateTimePicker dtpIlac;
        private Label labelIlacIsmi;
        private RadioButton radioButtonAc;
        private RadioButton radioButtonTok;
        private Label labelAcTok;
        private Label label1;
        private RadioButton radioButtonSabah;
        private RadioButton radioButtonOgle;
        private RadioButton radioButtonAksam;
        private Button buttonKayt;
        private ListView listViewIlaclar;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}