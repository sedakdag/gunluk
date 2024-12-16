namespace WinFormsApp2
{
    partial class Gecmis
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
            textboxGecmis = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(textboxGecmis);
            panel1.Location = new Point(-1, -1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(610, 488);
            panel1.TabIndex = 0;
            // 
            // textboxGecmis
            // 
            textboxGecmis.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textboxGecmis.Location = new Point(13, 13);
            textboxGecmis.Multiline = true;
            textboxGecmis.Name = "textboxGecmis";
            textboxGecmis.ReadOnly = true;
            textboxGecmis.Size = new Size(582, 461);
            textboxGecmis.TabIndex = 0;
            // 
            // Gecmis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(606, 485);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Gecmis";
            Text = "Geçmis";
            Load += Gecmis_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textboxGecmis;
    }
}