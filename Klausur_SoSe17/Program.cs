using System;

namespace Klausur_SoSe17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AnzPrim(10, 11, 12, 13, 14, 7));

            Ball b1 = new Ball(2.45);
            Ball b2 = new Ball(1.00, Sportarten.Golf);

            Console.WriteLine(b2.IstKleiner(b1));
        }

        public static void Tausch(int[,] array)
        {
            var temp = new int[array.GetLength(0)];

            for (int y = 0; y < array.GetLength(0); y++)
            {
                temp[y] = array[y, 0];
            }
            for (int y = 0; y < array.GetLength(0); y++)
            {
                array[y, 0] = array[y, array.GetLength(1) - 1];
                array[y, array.GetLength(1) - 1] = temp[y];
            }
        }

        public static int AnzPrim(params int[] array)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int counter1 = 0;

                for (int r = 2; r < array[i] / 2; r++)
                {
                    if (array[i] % r != 0)
                        counter1++;
                }
                if (counter1 == array[i] / 2 - 2)
                    counter++;
            }
            return counter;
        }
    }
}
