using System;
using System.Collections.Generic;
using System.Text;

namespace FundementalProgramming_agung
{
    class Persegi : BangunDatar
    {

        private double _sisi;

        public double persegi
        {
            get { return _sisi; }
            set { _sisi = value; }
        }

        public override double hitungLuas()
        {
            hitung = _sisi * _sisi;
            return hitung;
        }

        public override double hitungKeliling()
        {
            hitung = _sisi * 4;
            return hitung;
        }
    }
}
