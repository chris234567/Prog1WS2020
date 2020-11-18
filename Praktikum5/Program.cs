using System;

namespace Praktikum5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pascalsches Dreieck:");
            int[] f = { 1 };

            for (int i = 0; i < 8; i++)
            {
                f = PascalDreieck(f);
                Ausgabe(f);
            }

            Console.WriteLine();
            Console.WriteLine("Primzahlen bis 20");

            Primzahlen(20, true);
            const int Primzahlgrenze = 750000;

            Console.WriteLine($"Anzahl der Primzahlen bis {Primzahlgrenze}: {Primzahlen(Primzahlgrenze)}");
        }

        static int[] PascalDreieck(int[] f)
        {
            int[] ergebnis = new int[f.Length + 1];

            if (f.Length == 1)
                Console.WriteLine(f[0]);

            for (int i = 0; i < f.Length; i++)
            {
                if (i == 0)
                {
                    ergebnis[i] = f[i];
                }
                else
                {
                    ergebnis[i] = f[i - 1] + f[i];
                }
            }
            ergebnis[^1] = f[^1];

            return ergebnis;
        }

        static void Ausgabe(int[] f)
        {
            foreach (int element in f)
            {
                Console.Write(element);
            }
            Console.WriteLine();
        }

        static int Primzahlen(int n, bool ausgabe = false)
        {
            bool[] primeBool = new bool[n];

            for (int i = 0; i < primeBool.Length; i += 2)
            {
                primeBool[i] = false;

                if (i > 2)
                    primeBool[i - 1] = true;
            }

            primeBool[1] = false;
            primeBool[2] = true;

            for (int j = 3; j < primeBool.Length; j += 2)
            {
                for (int k = 5; k < primeBool.Length; k += 2)
                {
                    if (primeBool[j] != false)
                    {
                        if (k % j == 0)
                            primeBool[k] = false;
                    }
                }
            }

            int counter = 1; // wegen der 2 schon auf 1

            for ( int l = 3; l < primeBool.Length; l += 2) // alle geraden Zahlen werden uebersprungen
            {
                counter += 1;
            }
            Console.WriteLine(counter);
            return counter;
        }
    }
}
