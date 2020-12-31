using System;

namespace _2594519_Aufgabe3
{
    class Program
    {
        static void Main(string [] args)
        {
            Lautsprecher l = Lautsprecher.Simulation( "H-02" , "Wohnzimmer" ) ;
            Console.WriteLine(l.Einstellung);
            Console.WriteLine(l.AlsString());
            l.Lautstaerke = 75;
            Console.WriteLine(l.Lautstaerke);
            l.Lautstaerke = 15;
            Console.WriteLine(l.Lautstaerke);
        }

    }
}
