using System;

namespace ResponsiPemograman4295
{
    public class Karyawan
    {
        public string nik { get; set; }
        public string nama { get; set; }
        public int gajiBulanan { get; set; }

        public Karyawan (string nik, string nama, int gajiBulanan) {
            this.nik = nik;
            this.nama = nama;
            this.gajiBulanan = gajiBulanan < 0 ? 0 : gajiBulanan;
        }

        public void hasilData() {
            Console.WriteLine("{0} {1}      {2}", nik, nama, gajiBulanan);
        }

        public void kenaikanGaji() {
            int kenaikan;

            kenaikan = gajiBulanan * 110;
            gajiBulanan = kenaikan / 100;

            Console.WriteLine("Asyiiiik kenaikan gaji 10%!!");
        }
    }
}