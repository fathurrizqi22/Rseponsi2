using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;

namespace Responsi2
{
    class Program
    {
        static List<Penjualan> penjualans = new List<Penjualan>();
        static void Main()
        {

            bool status = true;

            while (status == true)
            {
                Console.Clear();
                Console.WriteLine("Pilih menu aplikasi\n");
                Console.WriteLine("1. Tambah Penjualan\n 2. Hapus penjualan\n 3. Tampilkan Penjualan\n 4. Keluar");
                Console.Write("Nomor Menu [1-4]: ");
                int pil = Convert.ToInt32(Console.ReadLine());

                switch (pil)
                {
                    case 1:
                        {
                            TambahPenjualan();
                            break;
                        }

                    case 2:
                        {
                            HapusPenjualan();
                            break;
                        }

                    case 3:
                        {
                            TampilkanPenjualan();
                            break;
                        }

                    case 4:
                        {
                            return;
                        }


                }



            }
        }

        static void TambahPenjualan()
        {
            Console.Clear();
            Console.WriteLine("===========Menu menambah penjualan========");

            Penjualan penjualan = new Penjualan();

            Console.Write("Nota ");
            penjualan.Nota = Console.ReadLine();

            Console.Write("Tanggal:t");
            penjualan.Tanggal = Console.ReadLine();

            Console.Write("Customer: ");
            penjualan.Customer = Console.ReadLine();

            Console.Write("Jenis [T/K] : ");
            penjualan.jenis = Console.ReadLine();

            Console.Write("TotalNota: ");
            penjualan.TotalNota= double.Parse(Console.ReadLine());

            penjualans.Add(penjualan);

            Console.ReadKey();

        }

        static void HapusPenjualan()
        {
            int no = -1, hapus = -1;
            Console.WriteLine("Hapus data penjualan\n");
            Console.Write("Nota: ");
            string nota = Console.ReadLine();

            foreach (Penjualan penjualan in penjualans)
            {
                no++;
                if (penjualan.Nota == nota)
                {
                    hapus = no;
                }
            }
            if (hapus != -1)
            {
                penjualans.RemoveAt(hapus);
                Console.WriteLine("Data penjualan berhasil dihapus ");
            }
            else
            {
                Console.WriteLine("Data tidak ditemukan");
            }

            Console.ReadKey();

        } 

        static void TampilkanPenjualan()
        {
            Console.Clear();

            string jenis;

            int no = 0;
            foreach (Penjualan penjualan in penjualans) {

                no++;
                jenis = "0";
                if (penjualan.jenis == "T")
                {
                   jenis= "Tunai";
                }
                else if (penjualan.jenis == "K")
                {
                   jenis = "Kredit";
                }
                Console.WriteLine(no + ". " + penjualan.Nota + penjualan.Tanggal + ", " + penjualan.Customer + ", " + jenis + ", " + penjualan.TotalNota);

            }

            Console.ReadKey();
            

        }
        

    }
}
