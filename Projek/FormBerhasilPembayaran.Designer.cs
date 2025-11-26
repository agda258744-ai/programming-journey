namespace Projek
{
    partial class FormBerhasilPembayaran
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
            lbLdeskripsi = new Label();
            btnOk = new Button();
            btnstruk = new Button();
            panel1 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbLdeskripsi
            // 
            lbLdeskripsi.AutoSize = true;
            lbLdeskripsi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLdeskripsi.Location = new Point(78, 64);
            lbLdeskripsi.Name = "lbLdeskripsi";
            lbLdeskripsi.Size = new Size(178, 17);
            lbLdeskripsi.TabIndex = 0;
            lbLdeskripsi.Text = "Pembayaran Telah Berhasil ";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(122, 123);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(79, 26);
            btnOk.TabIndex = 3;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnstruk
            // 
            btnstruk.Location = new Point(0, 0);
            btnstruk.Name = "btnstruk";
            btnstruk.Size = new Size(75, 23);
            btnstruk.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbLdeskripsi);
            panel1.Controls.Add(btnOk);
            panel1.Location = new Point(149, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 169);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 11);
            label3.Name = "label3";
            label3.Size = new Size(256, 21);
            label3.TabIndex = 6;
            label3.Text = "\U0001f973 YEY PEMBAYARAN BERHASIL";
            // 
            // FormBerhasilPembayaran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(672, 376);
            Controls.Add(panel1);
            Name = "FormBerhasilPembayaran";
            Text = "FormBerhasilPembayaran";
            Load += FormBerhasilPembayaran_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbLdeskripsi;
        private Button btnOk;
        private Button btnstruk;
        private Panel panel1;
        private Label label3;
    }
}