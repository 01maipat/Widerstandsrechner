using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Widerstandsberechner
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Berechnung
    {
        private double r1;
        private double r2;
        private double rend;
        private bool sorp;

        public void setr1(double wert1)
        {
            r1 = wert1;
        }
        public void setr2(double wert2)
        {
            r2 = wert2;
        }
        private double berechnen()
        {
            double endwert = 0;
            if (sorp == true)
            {
                endwert = r1 + r2;
            }
            else if (sorp == false)
            {
                endwert = (r1 * r2) / (r1 + r2);
            }
            return endwert;
        }
        public void setsorp(bool set)
        {
            sorp = set;
        }
        public double getrend()
        {
            rend = berechnen();
            return rend;
        }
    }
}
