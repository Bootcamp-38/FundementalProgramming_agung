using System;

namespace FundementalProgramming_agung
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Repeat = false;
            Trapesium trapesium = new Trapesium();
            Jajargenjang jajargenjang = new Jajargenjang();
            do
            {

                Console.WriteLine("Pilih Menu Perhitungan");
                Console.WriteLine("1. Segitiga");
                Console.WriteLine("2. Persegi Panjang");
                Console.WriteLine("3. Persegi");
                Console.WriteLine("4. Jajar Genjang");
                Console.WriteLine("5. Trapesium");
                Console.WriteLine();

                Console.Write("Pilihan yang anda Pilih : ");
                int menu;
                bool parsedSuccessfully = int.TryParse(Console.ReadLine(), out menu);

                if (parsedSuccessfully == false)
                {
                    Console.WriteLine("Masukkan dengan inputan angka! mau input ulang? (y/n)");
                    string jwb = Console.ReadLine();

                    if (jwb.ToLower() == "y")
                    {
                        Repeat = true;
                        Console.Clear();
                    }
                    else
                    {
                        Repeat = true;
                    }
                }

                else
                {
                    if (menu == 1)
                    {
                        bool dorepeatmenu = false;

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Pilih Perhitungan  1. Luas, 2. Keliling");
                            int menu_segitiga;
                            bool parsedSuccessfully2 = int.TryParse(Console.ReadLine(), out menu_segitiga);
                            if (parsedSuccessfully2 == false)
                            {
                                Console.WriteLine("Masukkan dengan inputan angka! mau input ulang? (y/n)");
                                string jwb = Console.ReadLine();

                                if (jwb.ToLower() == "y")
                                {
                                    dorepeatmenu = true;
                                    Console.Clear();
                                }
                                else
                                {
                                    dorepeatmenu = true;
                                }
                            }
                            else
                            {
                                if (menu_segitiga == 1)
                                {
                                    int alasb, tinggib;
                                    
                                    bool doRepeatLuasSeg = false;
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine(" Menghitung Luas Segitiga ");
                                        try
                                        {
                                            Console.Write("Masukan nilai Alas: ");
                                            alasb = int.Parse(Console.ReadLine());
                                            Console.Write("Masukan nilai Tinggi: ");
                                            tinggib = int.Parse(Console.ReadLine());
                                            Segitiga p = new Segitiga();
                                            p. alas= alasb;
                                            p.tinggi = tinggib;
                                            


                                            Console.Write("Luas segitiga adalah: "+ p.hitungLuas());
                                            Console.WriteLine();
                                            Console.Write("Apakah anda ingin mengulangi? (Y/N)");
                                            string jwb = Console.ReadLine();

                                            if (jwb.ToLower() == "y")
                                            {
                                                doRepeatLuasSeg = true;
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                doRepeatLuasSeg = false;
                                            }
                                        }
                                        catch (Exception e)
                                        {
                                            Console.WriteLine("Masukkan dengan inputan angka!");
                                            Console.Write("Apakah anda ingin mengulangi? (Y/N)");
                                            string jwb = Console.ReadLine();

                                            if (jwb.ToLower() == "y")
                                            {
                                                doRepeatLuasSeg = true;
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                doRepeatLuasSeg = false;
                                            }
                                        }

                                    } while (doRepeatLuasSeg);
                                }
                                else if (menu_segitiga == 2)
                                {
                                    int a1, a2, a3;
                                    
                                    bool doRepeatKelSeg = false;
                                    do
                                    {
                                        try
                                        {
                                            Console.Clear();
                                            Console.WriteLine(" Menghitung Keliling Segitiga ");
                                            Console.Write("Masukan Panjang Sisi A Segitiga : ");
                                            a1 = int.Parse(Console.ReadLine());
                                            Console.Write("Masukan Panjang Sisi B Segitiga : ");
                                            a2 = int.Parse(Console.ReadLine());
                                            Console.Write("Masukan Panjang Sisi C Segitiga : ");
                                            a3 = int.Parse(Console.ReadLine());

                                            Segitiga p = new Segitiga();
                                            p.sisi1 = a1;
                                            p.sisi2 = a2;
                                            p.sisi3 = a3;


                                            Console.Write("Keliling segitiga adalah: "+ p.hitungKeliling());
                                            Console.WriteLine();
                                            Console.Write("Apakah anda ingin mengulangi? (Y/N)");
                                            string jwb = Console.ReadLine();

                                            if (jwb.ToLower() == "y")
                                            {
                                                doRepeatKelSeg = true;
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                doRepeatKelSeg = false;
                                            }
                                        }
                                        catch (Exception e)
                                        {
                                            Console.WriteLine("Masukkan dengan angka!");
                                            Console.Write("Apakah anda ingin mengulangi? (Y/N)");
                                            string jwb = Console.ReadLine();

                                            if (jwb.ToLower() == "y")
                                            {
                                                doRepeatKelSeg = true;
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                doRepeatKelSeg = false;
                                            }
                                        }

                                    } while (doRepeatKelSeg);
                                }
                            }

                        } while (dorepeatmenu);
                    }
                    else if (menu == 2)
                    {
                        int panjangb, lebarb;
                        bool dorepeatpp = false;
                        do
                        {
                            try
                            {
                                Console.Clear();
                                Console.WriteLine(" Menghitung Luas dan Keliling Persegi Panjang ");
                                Console.Write("Masukan nilai Panjang : ");
                                panjangb = int.Parse(Console.ReadLine());
                                Console.Write("Masukan nilai Lebar : ");
                                lebarb = int.Parse(Console.ReadLine());
                                PersegiPanjang p = new PersegiPanjang();
                                p.panjang = panjangb;
                                p.lebar = lebarb;

                                Console.WriteLine("Luas Persegi Panjang : "+ p.hitungLuas());
                                Console.WriteLine("Keliling Persegi Panjang : "+ p.hitungKeliling());
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
                    else if (menu == 3)
                    {
                        double sisi;

                        bool dorepeatp = false;

                        do
                        {
                            try
                            {
                                Console.Clear();
                                Console.WriteLine(" Menghitung Luas dan Keliling Persegi ");
                                Console.Write("Silahkan masukkan panjang sisi : ");
                                sisi = double.Parse(Console.ReadLine());
                                Persegi p = new Persegi();
                                p.persegi = sisi;
                                Console.WriteLine("Luas Persegi :"+ p.hitungLuas());
                                Console.WriteLine("Keliling Persegi : "+ p.hitungKeliling());

                                Console.WriteLine();
                                Console.Write("Apakah anda ingin mengulangi? (Y/N)");
                                string jwb = Console.ReadLine();

                                if (jwb.ToLower() == "y")
                                {
                                    dorepeatp = true;
                                    Console.Clear();
                                }
                                else
                                {
                                    dorepeatp = false;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Masukkan dengan inputan angka!");
                                Console.Write("Apakah anda ingin mengulangi? (Y/N)");
                                string jwb = Console.ReadLine();

                                if (jwb.ToLower() == "y")
                                {
                                    dorepeatp = true;
                                    Console.Clear();
                                }
                                else
                                {
                                    dorepeatp = false;
                                }
                            }

                        } while (dorepeatp);



                    }
                    else if (menu == 4)
                    {
                        jajargenjang.inputjajar();

                    }
                    else if (menu == 5)
                    {
                        trapesium.inputtrapesium();
                    }
                }
            } while (Repeat);
        }
    }
}
