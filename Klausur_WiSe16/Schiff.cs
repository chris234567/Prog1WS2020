using System;
using System.Collections.Generic;
using System.Text;

namespace Klausur_WiSe16_17
{
    public enum Antriebe
    {
        Motor,
        Segel,
        Ruder,
    }
    class Schiff
    {
        private string name;
        private double laenge;
        private Antriebe antrieb;

        public double Laenge
        {
            get
            {
                return laenge;
            }
            set
            {
                laenge = value > 0 ? value : throw new ArgumentOutOfRangeException();
            }
        }

        public Schiff(string name, double laenge, Antriebe antrieb = Antriebe.Segel)
        {
            this.name = name;
            Laenge = laenge;
            this.antrieb = antrieb;
        }

        public double VRumpf()
        {
            return 2.43 * Math.Sqrt(Laenge);
        }

        public static double Mittel(Schiff[] schiffe, Antriebe antrieb)
        {
            var laengen = new double[schiffe.Length]; // es kann maximal so viele laengen wie schiffe geben

            for (int i = 0; i < schiffe.Length; i++)
            {
                if (schiffe[i].antrieb == antrieb)
                    laengen[i] = schiffe[i].laenge;
            }

            double value = 0;
            int counter = 0;

            foreach (var laenge in laengen)
            {
                if (laenge != 0)
                {
                    value += laenge;
                    counter++;
                }
            }
            return value / counter;
        }
    }
}
