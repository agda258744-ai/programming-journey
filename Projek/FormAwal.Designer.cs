namespace Projek
{
    partial class FormAwal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAwal));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnKeluar = new Button();
            btnMasuk = new Button();
            lbAnda = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(167, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(408, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Imprint MT Shadow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(167, 91);
            label1.Name = "label1";
            label1.Size = new Size(422, 25);
            label1.TabIndex = 1;
            label1.Text = "Selamat Datang Di Smoothies Bar Bar 23";
            // 
            // btnKeluar
            // 
            btnKeluar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKeluar.Location = new Point(425, 346);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(104, 39);
            btnKeluar.TabIndex = 2;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = true;
            btnKeluar.Click += btnKeluar_Click;
            // 
            // btnMasuk
            // 
            btnMasuk.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMasuk.Location = new Point(227, 346);
            btnMasuk.Name = "btnMasuk";
            btnMasuk.Size = new Size(111, 39);
            btnMasuk.TabIndex = 3;
            btnMasuk.Text = "Masuk";
            btnMasuk.UseVisualStyleBackColor = true;
            btnMasuk.Click += btnMasuk_Click;
            // 
            // lbAnda
            // 
            lbAnda.AutoSize = true;
            lbAnda.Location = new Point(320, 316);
            lbAnda.Name = "lbAnda";
            lbAnda.Size = new Size(111, 15);
            lbAnda.TabIndex = 4;
            lbAnda.Text = "Apakah Anda ingin ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(366, 359);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 5;
            label2.Text = "atau";
            label2.Click += label2_Click;
            // 
            // FormAwal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(lbAnda);
            Controls.Add(btnMasuk);
            Controls.Add(btnKeluar);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormAwal";
            Text = "FormAwal";
            Load += FormAwal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btnKeluar;
        private Button btnMasuk;
        private Label lbAnda;
        private Label label2;
    }
}