using System;

namespace Praktikum2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erfragt eine Zahl größer gleich 10 und kleiner als 10000

            Console.Write("Geben Sie eine Zahl größer gleich 10 oder kleiner als 10.000 ein: ");
            int eingabe = int.Parse(Console.ReadLine());

            while (eingabe < 10 || eingabe >= 10000)
            {
                Console.WriteLine("Ungültige Eingabe, bitte wiederholen.\n");
                Console.Write("Geben Sie eine Zahl größer gleich 10 oder kleiner als 10.000 ein: ");
                eingabe = int.Parse(Console.ReadLine());
            }
            
            // Errechnet alle kleineren Zahlen als die Eingabe, die durch 50 oder 500 teilbar sind 

            int teiler;

            if (eingabe < 1000)
            {
                teiler = 50;
            }
            else
            {
                teiler = 500;
            }

            int num = eingabe;

            Console.WriteLine($"{teiler}-er kleiner als " + num + ":");

            // Berechnet alle echten Teiler der Eingabe -

            while (num > 0)
            {

                if ((num / teiler) * teiler != 0)
                {
                    Console.WriteLine((num / teiler) * teiler);
                }

                num -= teiler;
            }

            Console.WriteLine("\nTeiler von " + eingabe + ":");

            int sum = 0;

            for (int i = eingabe - 1; i > 1; i--)
            {
                if ((eingabe % i) == 0)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                }
            }

            // - und gibt ihre Summe aus (oder gegebenenfalls, dass sie eine Primzahl ist)

            if (sum != 0)
            {
                Console.WriteLine("\nDie Summe aller echten Zeiler von " + eingabe + " ist " + sum);
            }
            else
            {
                Console.WriteLine($"{eingabe} ist eine Primzahl.");
            }

            // Berechnet die Anzahl der ungeraden und geraden Stellen aus

            int ungeradeStelle = 0;
            int geradeStelle = 0;

            int stellen = 0;

            if (eingabe >= 10 && eingabe < 100)
            {
                stellen = 1;
            }
            else if (eingabe < 1000)
            {
                stellen = 2;
            }
            else if (eingabe >= 1000 && eingabe < 10000)
            {
                stellen = 3;
            }

            for (int i = 0; i <= stellen; i++)
            {
                int stelle = eingabe / (int)Math.Pow(10, i);

                if ((stelle % 2) == 0)
                {
                    geradeStelle += 1;
                }
                else
                {
                    ungeradeStelle += 1;
                }
            }

            Console.WriteLine($"\nDie Zahl {eingabe} hat {geradeStelle} gerade und {ungeradeStelle} ungerade Ziffern.");

            // Berechnet das Produkt der ersten und letzten Ziffer der Eingabe

            int potenz = 0;

            if (eingabe < 100)
            {
                potenz = 1;
            }
            else if (eingabe >= 100 && eingabe < 1000)
            {
                potenz = 2;
            }
            else if (eingabe >= 1000 && eingabe < 10000)
            {
                potenz = 3;
            }

            int erstZiff = eingabe / (int)Math.Pow(10, potenz);
            int letztZiff = eingabe % 10;
            int sumZiff = erstZiff * letztZiff;

            Console.WriteLine($"\nDas Produkt der ersten und letzten Ziffer von {eingabe} ist {erstZiff}*{letztZiff}={sumZiff}.");

        }
    }
}
