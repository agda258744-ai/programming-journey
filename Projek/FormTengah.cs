using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek
{
    public partial class FormTengah : Form
    {
        public FormTengah()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Tombol lanjut
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide(); // Sembunyikan FromTengah
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }
  
        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
