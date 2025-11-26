using System.Security.Policy;

namespace Projek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void HitungPembayaran_Click(object sender, EventArgs e)
        {
            //  Validasi input yang wajib diisi manual
            if (NamaPembeli.Text == "" || ManggoThai.Text == "" || StrawberySmoothies.Text == "" || OreoSmoothies.Text == "" ||
                DragonSmoothies.Text == "" || AvocadoSmoothies.Text == "" || ChocolateSmoothies.Text == "" || this.tbuang.Text == "")
            {
                MessageBox.Show("Mohon lengkapi semua inputan sebelum menghitung pembayaran!", "Inputan kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // ====== SETELAH DIPASTIKAN TERISI =====
            string tbNama;
            double tbMT, tbSS, tbOS, tbDS, tbAS, tbCS, tbTotalBiaya, tbUuang, tbBiayapajak, tbTotalPembayaran, tbKembalian;
            double hargaMT, hargaSS, hargaOS, hargaDS, hargaAS, hargaCS;

            tbMT = double.Parse(ManggoThai.Text);
            tbSS = double.Parse(StrawberySmoothies.Text);
            tbOS = double.Parse(OreoSmoothies.Text);
            tbDS = double.Parse(DragonSmoothies.Text);
            tbAS = double.Parse(AvocadoSmoothies.Text);
            tbCS = double.Parse(ChocolateSmoothies.Text);
            tbNama = NamaPembeli.Text;

            hargaMT = tbMT * 12000;
            hargaSS = tbSS * 15000;
            hargaOS = tbOS * 10000;
            hargaDS = tbDS * 12000;
            hargaAS = tbAS * 15000;
            hargaCS = tbCS * 8000;

            tbTotalBiaya = hargaMT + hargaSS + hargaOS + hargaDS + hargaAS + hargaCS;
            tbBiayapajak = tbTotalBiaya * 0.05;

            tbTotalPembayaran = tbTotalBiaya + tbBiayapajak;
            tbUuang = double.Parse(this.tbuang.Text);
            tbKembalian = tbUuang - tbTotalPembayaran;

            TotalBiaya.Text = "Rp" + tbTotalBiaya.ToString("N0");
            TotalBiaya.Multiline = true;//biar tampil beberapa baris

            TotalBiaya.Text =
            "Manggo Smoothies x" + tbMT + " = Rp " + (tbMT * 12000).ToString("N0") + "\r\n" +
            "Strawbery Smoothies x" + tbSS + " = Rp " + (tbSS * 15000).ToString("N0") + "\r\n" +
            "Oreo Smoothies x" + tbOS + " = Rp " + (tbOS * 10000).ToString("N0") + "\r\n" +
            "Dragon Smoothies x" + tbDS + " = Rp " + (tbDS * 12000).ToString("N0") + "\r\n" +
            "Avocado Smoothies x" + tbAS + " = Rp " + (tbAS * 15000).ToString("N0") + "\r\n" +
            "Chocolate Smoothies x" + tbCS + " = Rp " + (tbCS * 8000).ToString("N0") + "\r\n" +
            "\r\n" +
            "Total Biaya = Rp " + tbTotalBiaya.ToString("N0");

            BiayaPajak.Text = "Rp" + tbBiayapajak.ToString("N0");
            TotalPembayaran.Text = "Rp" + tbTotalPembayaran.ToString("N0");
            Kembalian.Text = "Rp" + tbKembalian.ToString("N0");

            double Uuang = double.Parse(tbuang.Text);
            double TotalBayar = tbTotalPembayaran;
            double kembalian = Uuang - TotalBayar;
            if (Uuang < TotalBayar)
            {
                if (Uuang < TotalBayar)
                {
                    FormGagalPembayaran gagal = new FormGagalPembayaran();
                    gagal.ShowDialog(); // Tampilkan form gagal pembayaran
                }
            }
            else
            {
                // tidak Boleh Ada Apa-Apa Di Sini
                // Jangan Ada MessageBox
                //Jangan Show Foem Berhasil
                //Jangan Buka STruk
                //CUKUP KOSONG SEPERTI INI
            }
        }

        private void TotalBiaya_TextChanged(object sender, EventArgs e)
        {

        }

        private void Uang_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbK_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NamaPembeli.Focus();
        }

        private void ManggoThai_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbBP_Click(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            // Kosongkan semua texbox
            tbuang.Text = "";
            BiayaPajak.Text = "";
            TotalPembayaran.Text = "";
            Kembalian.Text = "";

            //Kalau ada textbox jumlah minuman yang dikosongkan
            NamaPembeli.Text = "";
            ManggoThai.Text = "";
            StrawberySmoothies.Text = "";
            OreoSmoothies.Text = "";
            DragonSmoothies.Text = "";
            AvocadoSmoothies.Text = "";
            ChocolateSmoothies.Text = "";

            NamaPembeli.Focus(); // Set fokus ke textbox pertama

        }

        private void NamaPembeli_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlanjut_Click(object sender, EventArgs e)
        {    
            string namapembeli = lbNama.Text;   

            // gabungkan menu yang dibeli
            string menu =
                "Mango Thai: " + lbMT.Text + "\n" +
                "Strawberry: " + lbSS.Text + "\n" +
                "Oreo: " + lbOS.Text + "\n" +
                "Dragon: " + lbDS.Text + "\n" +
                "Avocado: " + lbAS.Text + "\n" +
                "Chocolate: " + lbCS.Text;


        }

    }
    
}
