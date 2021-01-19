using System;

namespace _3594519_Aufgabe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Matrikelnummer eingeben: ");
            string matNummer = Console.ReadLine();
            int laengeNummer = matNummer.Length;
            int[] x1 = FeldFuellen1D(laengeNummer);
            int[] ergebnis = GeradeUngerade(x1, matNummer);
            FeldAusgeben(x1);
            FeldAusgeben(ergebnis);
        }

        public static int[] FeldFuellen1D(int length)
        {
            var rnd = new Random();
            var rndArray = new int[length];

            for (int i = 0; i < rndArray.Length; i++)
            {
                rndArray[i] = rnd.Next(0, 10); // 10 exklusive
            }
            return rndArray;
        }

        public static int[] GeradeUngerade(int[] rndArray, string matrikelNr)
        {
            var maNrArray = new int[matrikelNr.Length];

            for (int i = 0; i < maNrArray.Length; i++)
            {
                maNrArray[i] = matrikelNr[i] - 48; // ascii 0 = 48
            }

            var frankenstein = new int[2 * maNrArray.Length];
            int index = 0;

            // maNrArray.Length ist immer gleich rndArray.Length siehe Main()
            for (int i = 0; i < rndArray.Length; i++)
            {
                if (rndArray[i] % 2 == 0)
                {
                    frankenstein[index] = rndArray[i];
                    index++;
                }
                else if (rndArray[i] == 0)
                {
                    frankenstein[index] = 0;
                    index++;
                }
            }

            for (int i = 0; i < matrikelNr.Length; i++)
            {
                if (maNrArray[i] % 2 == 0)
                {
                    frankenstein[index] = maNrArray[i];
                    index++;
                }
                else if (matrikelNr[i] == 0)
                {
                    frankenstein[index] = 0;
                    index++;
                }
            }

            // alle geraden (mit 0) wurden gesetzt, jetzt kommen die ungeraden

            for (int i = 0; i < rndArray.Length; i++)
            {
                if (rndArray[i] % 2 != 0)
                {
                    frankenstein[index] = rndArray[i];
                    index++;
                }
            }

            for (int i = 0; i < matrikelNr.Length; i++)
            {
                if (maNrArray[i] % 2 != 0)
                {
                    frankenstein[index] = maNrArray[i];
                    index++;
                } 
            }

            return frankenstein;
        }

        public static void FeldAusgeben(int[] myArray)
        {
            foreach (var number in myArray)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}

