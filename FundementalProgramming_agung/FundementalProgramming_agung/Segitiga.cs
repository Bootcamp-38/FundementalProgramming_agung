using System;
using System.Collections.Generic;
using System.Text;

namespace FundementalProgramming_agung
{
    class Segitiga : BangunDatar
    {
        public double Alas;
        public double Tinggi;
        public double Sisi1;
        public double Sisi2;
        public double Sisi3;

        public double alas
        {
            get { return Alas; }
            set { Alas= value; }
        }
        public double tinggi
        {
            get { return Tinggi; }
            set { Tinggi = value; }
        }
        public double sisi1
        {
            get { return Sisi1; }
            set { Sisi1 = value; }
        }
        public double sisi2
        {
            get { return Sisi2; }
            set { Sisi2 = value; }
        }
        public double sisi3
        {
            get { return Sisi3; }
            set { Sisi3 = value; }
        }
        public override double hitungKeliling()
        {
            hitung = Sisi1 + Sisi2 + Sisi3;
            return hitung;
        }

        public override double hitungLuas()
        {
            hitung = Alas * Tinggi;
            return hitung;
        }
    }
}
