using System;
using System.IO;

namespace Klausur_WiSe17_18
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1

            //var myArray = new double[,] { { 0, 1, 2, 3, 4}, { 10, 11, 12, 13, 14}, { 20, 21, 22, 23, 24}, { 30, 31, 32, 33, 34} };

            //Console.WriteLine(MatrixSumme(myArray));

            //var array = new Medium[] { new Medium("eins", Medientyp.DVD), new Medium("zwei") };

            // 2

            //var newArray = Medium.Statistik(array);

            //foreach (var item in newArray)
            //{
            //    Console.WriteLine(item);
            //}

            // 3

            string[] bestellung = {"S2", "V1", "H6", "V1", "H4", "H6", "D2"};
            
            Dateiverarbeitung.Rechnung(bestellung);
        }

        public static double MatrixSumme(double[,] array2D)
        {
            // int length = array2D.GetLength(0) > array2D.GetLength(1) ? array2D.GetLength(0) : array2D.GetLength(1);

            double sum = 0;

            try
            {
                for (int y = 0; ; y++)
                {
                    for (int i = 1; i < array2D.GetLength(1) - 1; i++)
                    {
                        sum += array2D[y + i, y];
                        Console.WriteLine(array2D[y + i, y]);
                    }
                }
            }
            catch
            {
                return sum;
            }

            //for (int x = 0; x < array2D.GetLength(0) - 1; x++)
            //{
            //    for (int i = x + 1; i < array2D.GetLength(0); i++)
            //    {
            //        sum += array2D[i, x];
            //    }
            //}

            return sum;
        }

        public static int Zinsen(double start, double goal)
        {
            int year = 1;

            while (start < goal)
            {
                switch (year)
                {
                    case 1:
                    case 2:
                    case 3:
                        start += 0.3 * start;
                        break;
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                        start += 0.5 * start;
                        break;
                    case 8:
                        start += 1.0 * start;
                        break;
                    default:
                        start += 0.5 * start;
                        break;
                }
            }

            return year;
        }


    }
}
