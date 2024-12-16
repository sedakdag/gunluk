namespace WinFormsApp2
{
    partial class UykuGecmis
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
            textBoxUyku = new TextBox();
            SuspendLayout();
            // 
            // textBoxUyku
            // 
            textBoxUyku.Location = new Point(12, 12);
            textBoxUyku.Multiline = true;
            textBoxUyku.Name = "textBoxUyku";
            textBoxUyku.Size = new Size(468, 469);
            textBoxUyku.TabIndex = 0;
            // 
            // UykuGecmis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(492, 493);
            Controls.Add(textBoxUyku);
            Name = "UykuGecmis";
            Text = "UykuGecmis";
            Load += UykuGecmis_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUyku;
    }
}