using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Fungsi_3
{
    internal class Program
    {
        // Fungsi untuk mengkonversikan suhu dari Celcius ke Fahrenheit
        static double KonversiSuhu(double celcius)
        {
            return (celcius * 9 / 5) + 32;
        }

        static void Main(string[] args)
        {
            // Meminta input suhu dalam Celcius dari pengguna
            Console.Write("Masukkan suhu dalam Celcius: ");
            double celcius = Convert.ToDouble(Console.ReadLine());

            // Mengkonversi suhu menggunakan fungsi KonversiSuhu
            double fahrenheit = KonversiSuhu(celcius);

            // Menampilkan hasil konversi
            Console.WriteLine($"{celcius}°C sama dengan {fahrenheit}°F");
        }
    }
}
