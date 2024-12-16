
namespace WinFormsApp2
{
    partial class todolist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(todolist));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightPink;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 23);
            label1.Name = "label1";
            label1.Size = new Size(294, 30);
            label1.TabIndex = 0;
            label1.Text = "Merhaba , listene bir göz at..";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(341, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // todolist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(559, 494);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "todolist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "todolist";
            Load += todolist_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void todolist_Load(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
    }
}