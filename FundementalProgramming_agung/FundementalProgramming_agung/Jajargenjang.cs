using System;
using System.Collections.Generic;
using System.Text;

namespace FundementalProgramming_agung
{
    class Jajargenjang
    {
        public void inputjajar()
        {
            int alasb, tinggi;
            bool dorepeatpp = false;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine(" Menghitung Luas dan Keliling Jajar Genjang ");
                    Console.Write("Masukan nilai Alas : ");
                    alasb = int.Parse(Console.ReadLine());
                    Console.Write("Masukan nilai Tinggi : ");
                    tinggi = int.Parse(Console.ReadLine());

                    float luas, keliling;
                    luas = alasb * tinggi;
                    keliling = 2 * alasb + 2 * tinggi;

                    Console.WriteLine("Luas Persegi Jajar Genjang : "+  luas);
                    Console.WriteLine("Keliling Jajar Genjang : "+  keliling);
                    Console.WriteLine();
                    Console.Write("Apakah anda ingin mengulangi? (Y/N)");
                    string jwb = Console.ReadLine();

                    if (jwb.ToLower() == "y")
                    {
                        dorepeatpp = true;
                        Console.Clear();
                    }
                    else
                    {
                        dorepeatpp = false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Masukkan dengan inputan angka!");
                    Console.Write("Apakah anda ingin mengulangi? (Y/N)");
                    string jwb = Console.ReadLine();

                    if (jwb.ToLower() == "y")
                    {
                        dorepeatpp = true;
                        Console.Clear();
                    }
                    else
                    {
                        dorepeatpp = false;
                    }
                }

            } while (dorepeatpp);
        }
    }
}
