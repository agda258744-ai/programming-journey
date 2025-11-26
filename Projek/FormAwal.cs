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
    public partial class FormAwal : Form
    {
        public FormAwal()
        {
            InitializeComponent();
        }

        private void FormAwal_Load(object sender, EventArgs e)
        {
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            FormTengah formTengah = new FormTengah();
            formTengah.Show();
            this.Hide(); // Sembunyikan FromAwal

        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            //Tutup Aplikasi
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
