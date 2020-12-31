using System;

namespace Aufgabe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var array2D = new int[5, 5];
            var rnd = new Random();

            for (int y = 0; y < array2D.GetLength(0); y++)
            {
                for (int x = 0; x < array2D.GetLength(1); x++)
                {
                    int rndNum = 0; // 10 exclusive
                    bool newRnd = true;

                    while (!newRnd)
                    {
                        rndNum = rnd.Next(0, 10); // 10 exclusive

                        for (int i = 0; i < array2D.GetLength(0); i++) // check y axis for duplicates
                        {
                            if (rndNum == array2D[i, x])
                                newRnd = false;
                        }
                    }

                    while (!newRnd)
                    {
                        rndNum = rnd.Next(0, 10); // 10 exclusive

                        for (int i = 0; i < array2D.GetLength(1); i++) // check x axis for duplicates
                        {
                            if (rndNum == array2D[y, i])
                                newRnd = false;
                        }
                    }

                    array2D[y, x] = rndNum;
                }
            }

            PrintArray2D(array2D);
        }

        static void PrintArray2D(int[,] array2D)
        {
            for (int y = 0; y < array2D.GetLength(0); y++)
            {
                for (int x = 0; x < array2D.GetLength(1); x++)
                {
                    Console.Write(array2D[x, y]);
                }
                Console.WriteLine();
            }
        }
    }
}
