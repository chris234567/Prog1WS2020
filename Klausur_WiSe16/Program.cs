using System;

namespace Klausur_WiSe16_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Contains("asdaHalloasda", "Hallo"));

            int[,] f = { { 0, 1, 2, 3 }, { 4, 5, 6, 7 } };
            int[,] f2 = Transponieren(f);

            for (int y = 0; y < f.GetLength(0); y++)
            {
                for (int x = 0; x < f.GetLength(1); x++)
                {
                    Console.Write(f[y, x] + " ");
                }
                Console.WriteLine();
            }

            for (int y = 0; y < f2.GetLength(0); y++)
            {
                for (int x = 0; x < f2.GetLength(1); x++)
                {
                    Console.Write(f2[y,x] + " ");
                }
                Console.WriteLine();
            }

            var schiffe = new Schiff[] { new Schiff("eins", 2.54), new Schiff("zwei", 5.76), new Schiff("drei", 7.123, Antriebe.Motor) };

            Console.WriteLine(Schiff.Mittel(schiffe, Antriebe.Segel));
        }

        public static bool Contains(string s1, string s2)
        {
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == s2[0])
                {
                    int counter = 1;

                    for (int r = 1; r < s2.Length; r++)
                    {
                        if (s1[i + r] == s2[r])
                            counter++; 
                        else
                            break;
                    }
                    if (counter == s2.Length)
                        return true;
                }
            }
            return false;
        }

        public static int[,] Transponieren(int[,] input)
        {
            var myArray = new int[input.GetLength(1), input.GetLength(0)];

            for (int y = 0; y < input.GetLength(0); y++)
            {
                for (int x = 0; x < input.GetLength(1); x++)
                {
                    myArray[x, y] = input[y, x];
                }
            }

            return myArray;
        }
    }
}
