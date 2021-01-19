using System;

namespace _3594519_Aufgabe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sparplan(1000, 155, 0.001);
        }

        public static void Sparplan(double wunschBetrag, double sparBetrag, double zinsSatz)
        {
            int jahre = 0;
            double betrag = 0;
            double eingezahlt = 0;
            bool weiter = true;

            while (weiter)
            {
                jahre++;
                eingezahlt += sparBetrag;
                betrag += (zinsSatz * betrag) + sparBetrag;

                Console.WriteLine(" {0}. Jahr:  {1:f}, eingezahlt: {2:f} ", jahre, betrag, eingezahlt);

                // wunschBetrag wurde erreicht -> verlasse die schleife
                if (wunschBetrag - betrag <= sparBetrag)
                {
                    jahre++;
                    eingezahlt += wunschBetrag - betrag;
                    betrag = wunschBetrag;
                    weiter = false;

                    Console.WriteLine(" {0}. Jahr: {1:f}, eingezahlt: {2:f} ", jahre, betrag, eingezahlt);
                }

            }
            Console.WriteLine("Summe: {0:f} in {1} Jahren.", eingezahlt, jahre);
        }
    }
}
