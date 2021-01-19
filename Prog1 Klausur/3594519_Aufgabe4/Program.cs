using System;

namespace _3594519_Aufgabe4
{
    enum LightType
    {
        Panel,
        Sparkle,
        LED,
        Spot,
        FogMachine,
    }

    class Program
    {
        static double FractionFog(LightType[,] map)
        {
            double fogs = 0;
            double all = 0;

            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    fogs += map[y, x] == LightType.FogMachine ? 1 : 0;
                    all++;
                }
            }

            return fogs / all; // beide variablen sind double -> double division
        }

        static void PrintField(LightType[,] map, int x, int y)
        {
            var hoehe = map.GetLength(0);
            var breite = map.GetLength(1);
            

            if (y < 0)
                y = hoehe - (y * -1 % hoehe);
            else
                y = y % hoehe; 
            
            if (x < 0)
                x = breite - (x * -1 % breite);
            else
                x = x % breite;

            string characters;

            switch (map[y, x])
            {
                case LightType.Panel: characters = "  "; break;
                case LightType.Sparkle: characters = "░░"; break;
                case LightType.LED: characters = "▓▓"; break;
                case LightType.Spot: characters = "//"; break;
                case LightType.FogMachine: characters = ":)"; break;
                default: characters = "??"; break;
            }
            Console.Write(characters);
        }


        static void Print(LightType[,] map)
        {
            // Dies sind die Zeichen für die Ausgaben:
            //
            // Panel:       "  "
            //
            // Sparkle:      ░░
            //
            // LED:          ▓▓
            //
            // Spot:         //
            //
            // FogMachine:   :)
            //
            // alles andere: ??
            //

            for (int y1 = 0; y1 < map.GetLength(0); y1++)
            {
                for (int x1 = 0; x1 < map.GetLength(1); x1++)
                {
                    PrintField(map, x1, y1);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            LightType[,] map = new LightType[,] {
                    { LightType.Sparkle, LightType.Panel, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Sparkle, LightType.Sparkle, LightType.Panel, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Sparkle }, //  1
                    { LightType.Sparkle, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Sparkle, LightType.Panel, LightType.Sparkle,LightType.Sparkle, LightType.Panel, LightType.Sparkle, LightType.FogMachine, LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Sparkle, LightType.Panel, LightType.Sparkle },
                    { LightType.Sparkle, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Sparkle,LightType.Sparkle, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Sparkle },
                    { LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Sparkle,LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Sparkle },
                    { LightType.Sparkle, LightType.Sparkle, LightType.LED, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Spot, LightType.Sparkle, LightType.Panel, LightType.Sparkle,LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Spot, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Sparkle }, //  5
                    { LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Panel,LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Panel }, //  6
                    { LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Panel, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle,LightType.Panel, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Panel, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle },
                    { LightType.Panel, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Panel,LightType.Panel, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Panel },
                    { LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Panel, LightType.Sparkle, LightType.LED, LightType.LED, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle,LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.FogMachine, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle },
                    { LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.FogMachine, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Sparkle,LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Sparkle }, // 10
                    { LightType.Sparkle, LightType.Panel, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Sparkle,LightType.Sparkle, LightType.Panel, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Sparkle }, // 11
                    { LightType.Sparkle, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Sparkle, LightType.Panel, LightType.Sparkle,LightType.Sparkle, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Sparkle, LightType.Panel, LightType.Sparkle },
                    { LightType.Sparkle, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Spot, LightType.Sparkle,LightType.Sparkle, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Sparkle },
                    { LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Panel,LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Spot, LightType.Sparkle, LightType.FogMachine, LightType.Sparkle },
                    { LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Spot, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Sparkle,LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Spot, LightType.FogMachine, LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Sparkle }, // 15
                    { LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Panel,LightType.Panel, LightType.Panel, LightType.LED, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Panel }, // 16
                    { LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Panel, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle,LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Panel, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle },
                    { LightType.Panel, LightType.Panel, LightType.Panel, LightType.Panel, LightType.LED, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Sparkle,LightType.Panel, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Panel },
                    { LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Panel, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle,LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Panel, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle, LightType.Sparkle },
                    { LightType.Panel, LightType.FogMachine, LightType.Sparkle, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Sparkle,LightType.Panel, LightType.Panel, LightType.Sparkle, LightType.Panel, LightType.FogMachine, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Panel, LightType.Sparkle }  // 20
                };

            Console.WriteLine("Anteil Nebelmaschinen: {0:#0.0}%", FractionFog(map) * 100);

            Console.Write("oben links: ");
            PrintField(map, 0, 0);
            Console.WriteLine();

            Console.Write("unten rechts: ");
            PrintField(map, -1, -1);
            Console.WriteLine();

            Console.Write("irgendwo weit: ");
            PrintField(map, 6524558, -72347); // Sollte ein seltenes Quadrat zeigen
            Console.WriteLine();

            Print(map);
        }
    }
}
