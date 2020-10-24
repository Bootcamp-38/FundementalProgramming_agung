using System;
using System.Collections.Generic;
using System.Text;

namespace FundementalProgramming_agung
{
    abstract class BangunDatar
    {
        public double hitung;

        public double Hitung
        {
            get { return hitung; }
            set { hitung = value; }
        }

        public abstract double hitungLuas();

        public abstract double hitungKeliling();
    }
}
