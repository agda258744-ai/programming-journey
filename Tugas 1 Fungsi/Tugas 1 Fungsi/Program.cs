using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_1_Fungsi
{
    internal class Program
    {
        // Fungsi kali menerima tiga bilangan dan menampilkan hasil perkalian
        static void kali(int a, int b, int c)
        {
            int hasil = a * b * c;
            Console.WriteLine("hasil perkalian: " + hasil);
        }
       
        static void Main(string[] args)
        {
            Console.Write("Masukkan bilngan pertama: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Masukkan bilngan kedua: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Masukkan bilngan ketiga: ");
            int z = int.Parse(Console.ReadLine());

            kali(x, y, z); //Panggil fungsi
        }


    }
}