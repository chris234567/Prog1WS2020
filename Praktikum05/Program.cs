using System;

namespace Praktikum5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pascalsches Dreieck:");
            int[] f = { 1, 2, 2, 1 };

            for (int i = 0; i < 8; i++)
            {
                f = PascalDreieck(f);
                Ausgabe(f);
            }

            Console.WriteLine();
            Console.WriteLine("Primzahlen bis 20");

            Primzahlen(120, true);
            const int Primzahlgrenze = 750000;

            Console.WriteLine($"Anzahl der Primzahlen bis {Primzahlgrenze}: {Primzahlen(Primzahlgrenze)}");
        }

        static int[] PascalDreieck(int[] f = null)
        {
            if (f == null) // wenn keine Eingabe aka null uebergeben wurde, wird f mit 1 initialisiert
            {
                f = new int[]{ 1 };
                return f;
            }

            int[] ergebnis = new int[f.Length + 1]; // Array mit einem zusaetzlichen Element

            ergebnis[0] = 1; // linker Rand ist immer 1

            for (int i = 1; i < f.Length; i++) // geht alle Elemente des Input Array durch
            {
                ergebnis[i] = f[i - 1] + f[i]; 
            }
            ergebnis[^1] = 1; // rechter Rand ist immer 1

            return ergebnis;
        }

        static void Ausgabe(int[] f)
        {
            foreach (int element in f) // gibt alle Element aus f in einer Zeile aus
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }

        static int Primzahlen(int n, bool ausgabe = false)
        {
            bool[] primeBool = new bool[n + 1]; // Array mit einem Element mehr da 0 bei den Zahlen dabei ist

            for (int i = 3; i < primeBool.Length; i += 2) // alle ungeraden Zahlen auf true | alle geraden auf false
            {
                primeBool[i] = true;
            }

            primeBool[2] = true; // 2 wird auf true gesetzt da die Schleife oben nur die ungeraden auf true gesetzt hat

            int primzahlCounter = 1; // wegen der 2 schon auf 1

            if (ausgabe)
                Console.Write("2");

            for (long j = 3; j < primeBool.Length; j += 2) // alle ungeraden Zahlen werden geprueft
            {
                if (primeBool[j]) // prueft ob Primzahl
                {
                    primzahlCounter += 1;

                    if (ausgabe)
                        Console.Write($"   {j}");
                    for (long k = (long)Math.Pow(j, 2); k < primeBool.Length; k += 2) // streicht alle vielfachen von der Primzahl j
                        if (primeBool[j] && (k % j == 0)) // Bedingung keine Primzahl zu sein
                            primeBool[k] = false;
                }
            }

            Console.Write("\n");
            return primzahlCounter;
        }
    }
}
