using System;
using System.Collections.Generic;
namespace week_13
{
    class Program
    {
        public class dataTabel
        {
            public string NIM { get; set; }
            public string Nama { get; set; }
            public string jenisKelamin { get; set; }
            public int tahunMasuk { get; set; }
            public string programStudi { get; set; }
            public string kelas { get; set; }
        }
        static void Main(string[] args)
        {
            List<dataTabel> tabel = new List<dataTabel>();
            int itung = 0;
            while (true)
            {
                Console.WriteLine("Berapa data?");
                int banyakData = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < banyakData; i++)
                {
                    Console.WriteLine();
                    itung++;
                    Console.WriteLine($"data ke-{itung}");
                    Console.Write("NIM \t\t : ");
                    string nim = Console.ReadLine();

                    Console.Write("NAMA \t\t : ");
                    string nama = Console.ReadLine();
                    Console.Write("JENIS KELAMIN \t : ");
                    string jenis = Console.ReadLine();
                    Console.Write("TAHUN MASUK \t : ");
                    int tahun = Convert.ToInt32(Console.ReadLine());
                    Console.Write("PROGRAM STUDI \t : ");
                    string studi = Console.ReadLine();
                    Console.Write("KELAS \t\t : ");
                    string elas = Console.ReadLine();
                    tabel.Add(new dataTabel()
                    {
                        NIM = nim,
                        Nama = nama,
                        jenisKelamin = jenis,
                        tahunMasuk =
                   tahun,
                        programStudi = studi,
                        kelas = elas
                    });
                }
                Console.WriteLine();
                Console.Write("PRINT HASIL ? (y/n) ... ");
                string print = Console.ReadLine();
                if (print == "n")
                {
                    Environment.Exit(1);
                }
                if (print == "y")
                {
                    Console.Clear();
                    Console.Write(String.Format("{0,-4} {1,-5} {2,-25} {3,-18} {4,-15} {5,-20} {6,-8}", "NO",
                    "NIM", "NAMA", "JENIS KELAMIN", "TAHUN MASUK", "PROGRAM STUDI", "KELAS\n"));
                    foreach (var ketik in tabel)
                    {
                        int no = 0;
                        Console.Write(String.Format("{0,-3}{1,-5}{2,-25}{3,-18}{4,-15}{5,-20}{6,-8}", (no + 1),
                       ketik.NIM
                        , ketik.Nama, ketik.jenisKelamin, ketik.tahunMasuk, ketik.programStudi,
                       $"{ketik.kelas}\n"));
                        no++;
                    }
                }
                Console.Write("\nTambah Data? (y/n) ... ");
                string ulang = Console.ReadLine();
                if (ulang == "n")
                {
                    Environment.Exit(1);
                }
                Console.WriteLine();
            }
        }
    }
}