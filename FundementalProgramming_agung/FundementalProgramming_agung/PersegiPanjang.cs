using System;
using System.Collections.Generic;
using System.Text;

namespace FundementalProgramming_agung
{
    class PersegiPanjang : BangunDatar
    {
        private double Panjang;
        private double Lebar;
        public double panjang
        {
            get { return Panjang; }
            set { Panjang = value; }
            
        }
        public double lebar
        {
            get { return Lebar; }
            set { Lebar = value; }

        }
        public override double hitungKeliling()
        {
            hitung = 2 * Panjang + 2 * Lebar;
            return hitung;
        }

        public override double hitungLuas()
        {
            hitung = Panjang * Lebar;
            return hitung;
        }
    }
}
