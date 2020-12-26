using System;

namespace UebungsaufgabenWoche09
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aufgabe 1 // funcions only with original Reindeer and Sled class

            //var dasher = new Reindeer();
            //var rudolph = new Reindeer();

            //dasher.Name = "Dasher";
            //dasher.Age = 17;
            //dasher.RedNose = false;

            //rudolph.Name = "Rudolph";
            //rudolph.Age = 18;
            //rudolph.RedNose = true;

            //PrintText(dasher.Name, dasher.Age, dasher.RedNose);
            //PrintText(rudolph.Name, rudolph.Age, rudolph.RedNose);

            // Aufgabe 2, 3, 4

            Sled meinSchlitten = new Sled(
                new Reindeer[] {
                new Reindeer("Dasher", 17, false),
                new Reindeer("Dancer", 17, false),
                new Reindeer("Prancer", 15, false),
                new Reindeer("Vixon", 16, false),
                new Reindeer("Comet", 16, false),
                new Reindeer("Cupid", 18, false),
                new Reindeer("Donner", 16, false),
                new Reindeer("Blitzen", 17, false),
                new Reindeer("Rudolph", 18, true)
                }
            );

            Console.WriteLine(meinSchlitten.Reindeers);

            // Aufgabe 5

            var mySled = Sled.ReindeerSquadronAssemble(@"C:\Users\Chris\source\Prog12020\UebungsaufgabenWoche09\myReindeers.txt");

            Console.WriteLine(mySled.Reindeers);
        }

        public static void PrintText(string name, int age, bool redNose)
        {
            Console.WriteLine($"\n--- {name} ---");
            Console.WriteLine($"{name} ist {age} Jahre alt und hat " + (redNose ? "eine" : "keine") + " rote Nase.");

            if (!redNose)
                Console.WriteLine("Nicht so schlimm.");
        }
    }
}
