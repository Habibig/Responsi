using System;

namespace ResponsiPemograman4295
{
    class Program
    {
        static void Main(string[] args) 
        {
            Karyawan karyawan1 = new Karyawan("190302123", "Paijo", 3000000);
            Karyawan karyawan2 = new Karyawan("190302124", "Jono", 2000000);

            Console.WriteLine("No Nik/Nama      Gaji Bulanan");
            Console.WriteLine("-----------------------------");
            Console.Write("1 ");karyawan1.hasilData();
            Console.Write("2 ");karyawan2.hasilData();
            Console.WriteLine();

            karyawan1.kenaikanGaji();
            karyawan2.kenaikanGaji();

            Console.WriteLine();
            Console.WriteLine("No Nik/Nama      Gaji Bulanan");
            Console.WriteLine("-----------------------------");
            Console.Write("1 ");karyawan1.hasilData();
            Console.Write("2 ");karyawan2.hasilData();
        }
    }
}