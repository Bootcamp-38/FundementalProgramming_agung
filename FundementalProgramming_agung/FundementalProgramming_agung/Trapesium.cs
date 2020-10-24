using System;
using System.Collections.Generic;
using System.Text;

namespace FundementalProgramming_agung
{
    class Trapesium
    {
        
        public void inputtrapesium()
        {
            int Patas, Pbawah, t;
            double x = 0.5;
            double Luas;
            bool dorepeatT = false;

            do
            {
               
                try
                {
                    Console.Clear();
                    Console.WriteLine(" Menghitung Luas Trapesium ");
                    Console.Write("Masukkan Panjang sisi atas  : ");
                    Patas = int.Parse(Console.ReadLine());
                    Console.Write("Masukkan Panjang sisi bawah : ");
                    Pbawah = int.Parse(Console.ReadLine());
                    Console.Write("Masukkan Tinggi             : ");
                    t = int.Parse(Console.ReadLine());
                    Luas = x * (Patas + Pbawah) * t;
                    Console.WriteLine("Hasilnya luas Trapesium adalah : " + Luas);

                    Console.WriteLine();
                    Console.Write("Apakah anda ingin mengulangi? (Y/N)");
                    string jwb = Console.ReadLine();

                    if (jwb.ToLower() == "y")
                    {
                        dorepeatT = true;
                        Console.Clear();
                    }
                    else
                    {
                        dorepeatT = false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Masukkan dengan inputan angka!");
                    Console.Write("Apakah anda ingin mengulangi? (Y/N)");
                    string jwb = Console.ReadLine();

                    if (jwb.ToLower() == "y")
                    {
                        dorepeatT = true;
                        Console.Clear();
                    }
                    else
                    {
                        dorepeatT = false;
                    }
                }
            } while (dorepeatT);
        }
    }
}
