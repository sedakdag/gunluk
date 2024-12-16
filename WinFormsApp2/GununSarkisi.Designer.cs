namespace WinFormsApp2
{
    partial class GununSarkisi
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
            textboxSarkiIsmi = new TextBox();
            labelSarkiIsmi = new Label();
            panel1 = new Panel();
            label1 = new Label();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            buttonAra = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // textboxSarkiIsmi
            // 
            textboxSarkiIsmi.BackColor = Color.Silver;
            textboxSarkiIsmi.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textboxSarkiIsmi.ForeColor = Color.Linen;
            textboxSarkiIsmi.Location = new Point(374, 119);
            textboxSarkiIsmi.Multiline = true;
            textboxSarkiIsmi.Name = "textboxSarkiIsmi";
            textboxSarkiIsmi.Size = new Size(227, 39);
            textboxSarkiIsmi.TabIndex = 0;
            textboxSarkiIsmi.TextChanged += textboxSarkiIsmi_TextChanged;
            // 
            // labelSarkiIsmi
            // 
            labelSarkiIsmi.AutoSize = true;
            labelSarkiIsmi.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelSarkiIsmi.ForeColor = Color.Linen;
            labelSarkiIsmi.Location = new Point(249, 27);
            labelSarkiIsmi.Name = "labelSarkiIsmi";
            labelSarkiIsmi.Size = new Size(274, 34);
            labelSarkiIsmi.TabIndex = 1;
            labelSarkiIsmi.Text = "Günün Şarkısını Seç!";
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(labelSarkiIsmi);
            panel1.Location = new Point(-8, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 86);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 121);
            label1.Name = "label1";
            label1.Size = new Size(187, 30);
            label1.TabIndex = 3;
            label1.Text = "Bir şarkı ismi girin:";
            label1.Click += label1_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(25, 207);
            webView21.Name = "webView21";
            webView21.Size = new Size(717, 380);
            webView21.TabIndex = 4;
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click;
            // 
            // buttonAra
            // 
            buttonAra.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAra.Location = new Point(522, 164);
            buttonAra.Name = "buttonAra";
            buttonAra.Size = new Size(79, 37);
            buttonAra.TabIndex = 5;
            buttonAra.Text = "Ara";
            buttonAra.UseVisualStyleBackColor = true;
            buttonAra.Click += buttonAra_Click;
            // 
            // GununSarkisi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 615);
            Controls.Add(buttonAra);
            Controls.Add(webView21);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(textboxSarkiIsmi);
            Name = "GununSarkisi";
            Text = "GununSarkisi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textboxSarkiIsmi;
        private Label labelSarkiIsmi;
        private Panel panel1;
        private Label label1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button buttonAra;
    }
}