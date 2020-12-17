using System;
using System.Globalization;
using System.Runtime.Intrinsics;

namespace _1PraktikumsaufgabeOnlineShop
{
    class Program
    {

        static void Main(string[] args)
        {
            double pfefferMenge;
            double paprikaMenge;
            double curryMenge;

            Console.OutputEncoding = System.Text.Encoding.UTF8;  // enable unicode output

            Console.WriteLine("Herzlich Wilkommmen bei Scharfe Küche!");
            Console.Write("Pfeffer   (à 5,10€):   ");
            pfefferMenge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Paprika   (à 3,90€):   ");
            paprikaMenge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Curry     (à 4,50€):   ");
            curryMenge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            double preis = pfefferMenge * 5.10 + paprikaMenge * 3.90 + curryMenge * 4.50;

            if (preis <= 10)    // Mindestbestellwertabfrage
            {
                Console.WriteLine("Ihre Bestellung erreicht nicht den Mindestbestellwert von 10,00 Euro");
            }
            else if (25 < preis && preis < 30)    // Abfrage ob Preis im kritischen Bereich
            {

                double dif = (30 - preis);

                Console.WriteLine("{0,1} {1,1:N2} {2,10}", "Ihnen fehlen nur noch", dif, "Euro bis zum kostenfreien Versand!");
                Console.WriteLine("Wollen Sie noch eine Dose pfefferMenge mehr bestellen und den Versand");
                Console.Write("sparen(ja | nein) ?");

                String answer = Console.ReadLine();

                if (answer == "ja")    // Abrage ob Versand gespart werden soll
                {
                    pfefferMenge += 1;
                }

                // Bestellbestätigung

                preis = pfefferMenge * 5.10 + paprikaMenge * 3.90 + curryMenge * 4.50;

                Console.WriteLine(" ");
                Console.WriteLine("Bestellbestätigung durch Scharfe Küche:");

                double pfefferMengepreis = pfefferMenge * 5.10;
                double paprikaMengepreis = paprikaMenge * 3.90;
                double curryMengepreis = curryMenge * 4.50;

                Console.WriteLine($"{"Pfeffer",1} {pfefferMenge,25} {"x 5,10",3} {pfefferMengepreis,17:N2} {"EUR"}");
                Console.WriteLine($"{"Paprika",1} {paprikaMenge,25} {"x 5,10",3} {paprikaMengepreis,17:N2} {"EUR"}");
                Console.WriteLine($"{"Curry",1} {curryMenge,27} {"x 5,10",3} {curryMengepreis,17:N2} {"EUR"}");
                Console.WriteLine("‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐-----");
                Console.WriteLine($"{"Zwischensumme",1} {preis,44:N2} {"EUR",-1}");

                double mwst = (preis / 116 * 16);

                Console.WriteLine($"{"Enthaltene MwSt (16%)",1} {mwst,36:N2} {"EUR",-1}");

                if (preis <= 30)    // Versandberechnung
                {
                    Console.WriteLine("Versandpauschale                                      3,90 EUR");
                    Console.WriteLine("‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐-----");

                    double sum = (preis + 3.90);

                    Console.WriteLine($"{"Summe",1} {sum,52:N2} {"EUR",-1}");
                }
                else
                {
                    Console.WriteLine("Versandpauschale                                      0,00 EUR");
                    Console.WriteLine("‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐-----");
                    Console.WriteLine($"{"Summe",1} {preis,52:N2} {"EUR",-1}");
                }
            }
            else
            {
                // Bestellbestätigung

                preis = pfefferMenge * 5.10 + paprikaMenge * 3.90 + curryMenge * 4.50;

                Console.WriteLine(" ");
                Console.WriteLine("Bestellbestätigung durch Scharfe Küche:");

                double pfefferMengepreis = pfefferMenge * 5.10;
                double paprikaMengepreis = paprikaMenge * 3.90;
                double curryMengepreis = curryMenge * 4.50;

                Console.WriteLine($"{"Pfeffer",1} {pfefferMenge,25} {"x 5,10",3} {pfefferMengepreis,17:N2} {"EUR"}");
                Console.WriteLine($"{"Paprika",1} {paprikaMenge,25} {"x 5,10",3} {paprikaMengepreis,17:N2} {"EUR"}");
                Console.WriteLine($"{"Curry",1} {curryMenge,27} {"x 5,10",3} {curryMengepreis,17:N2} {"EUR"}");
                Console.WriteLine("‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐-----");
                Console.WriteLine($"{"Zwischensumme",1} {preis,44:N2} {"EUR",-1}");

                double mwst = (preis / 116 * 16);

                Console.WriteLine($"{"Enthaltene MwSt (16%)",1} {mwst,36:N2} {"EUR",-1}");

                if (preis <= 30)    // Versandberechnung
                {
                    Console.WriteLine("Versandpauschale                                      3,90 EUR");
                    Console.WriteLine("‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐-----");

                    double sum = (preis + 3.90);

                    Console.WriteLine($"{"Summe",1} {sum,52:N2} {"EUR",-1}");
                }
                else
                {
                    Console.WriteLine("Versandpauschale                                      0,00 EUR");
                    Console.WriteLine("‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐-----");
                    Console.WriteLine($"{"Summe",1} {preis,52:N2} {"EUR",-1}");
                }

            }
        }
    }
}
