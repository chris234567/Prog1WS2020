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
                    int rndNum; // 10 exclusive
                    bool newRnd;

                    do
                    {
                        rndNum = rnd.Next(0, 10); // 10 exclusive
                        newRnd = true;

                        for (int i = 0; i < array2D.GetLength(0); i++) // can be done in one for loop because of quadratic property
                        {
                            if (rndNum == array2D[i, x]) // check y axis for duplicates
                                newRnd = false;

                            if (rndNum == array2D[y, i]) // check x axis for duplicates
                                newRnd = false;
                        }

                    } while (!newRnd);

                    array2D[y, x] = rndNum;
                }
            }

            PrintArray2D(array2D);

            Console.WriteLine($"\nThe diagonal sum is : {DiagonalSum(array2D)}");
        }

        static void PrintArray2D(int[,] array2D)
        {
            for (int y = 0; y < array2D.GetLength(0); y++)
            {
                for (int x = 0; x < array2D.GetLength(1); x++)
                {
                    Console.Write(array2D[x, y] + " ");
                }
                Console.WriteLine();
            }
        }

        static int DiagonalSum(int[,] array2D)
        {
            int dim1 = array2D.GetLength(0);
            int dim2 = array2D.GetLength(1);

            if (dim1 != dim2 && (dim1 % 2 != 0) && (dim2 % 2 != 0)) // not quadratic nor odd dimensions
                return 0;

            int firstDiagonal = 0;
            int x1 = 0;
            int secondDiagonal = 0;
            int x2 = dim2 - 1;

            for (int y = 0; y < dim1; y++)
            {
                firstDiagonal += array2D[y, x1];
                x1++;

                secondDiagonal += array2D[y, x2];
                x2--;
            }

            secondDiagonal -= array2D[dim1 / 2, dim1 / 2]; // "skip" middle element ( duplicate )

            return firstDiagonal + secondDiagonal;
        }
    }
}
