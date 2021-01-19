using System;

namespace _3594519_Aufgabe3
{
    public enum FahrzeugTyp
    {
        Kompakt,
        SUV,
        Kombi,
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fahrzeug f1 = new Fahrzeug("VW Golf", 6.3, FahrzeugTyp.Kompakt);
            Fahrzeug f2 = new Fahrzeug("BMW X5", 8.2, FahrzeugTyp.SUV);
            Fahrzeug f3 = new Fahrzeug("Mercedes GLC", 7.3, FahrzeugTyp.SUV);
            Fahrzeug f4 = new Fahrzeug("Audi A4", 6.9, FahrzeugTyp.Kombi);
            Fahrzeug f5 = new Fahrzeug("Smart", 4.8, FahrzeugTyp.Kompakt);
            Fahrzeug f6 = new Fahrzeug("Audi A2", 6.2, FahrzeugTyp.Kombi);
            Fahrzeug f7 = new Fahrzeug("BMW 530", 7.8, FahrzeugTyp.Kombi);

            Console.WriteLine(f1);

            Fahrzeug[] fahrzeuge = new Fahrzeug[] { f1, f2, f3, f4, f5, f6, f7 };
            Fuhrpark fuhrpark = new Fuhrpark(fahrzeuge);

            Console.WriteLine(fuhrpark.Sparsamstes().ToString());
        }
    }
}
