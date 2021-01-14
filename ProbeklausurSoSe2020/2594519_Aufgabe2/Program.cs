using System;

namespace _2594519_Aufgabe2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myArray = new int[5, 5];
            var myRnd = new Random();

            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    var rndNum = 0;
                    var newNum = true;

                    do
                    {
                        rndNum = myRnd.Next(0, 10); // 10 exclusive
                        newNum = true;

                        for (int y1 = 0; y1 < myArray.GetLength(0); y1++) // check col
                        {
                            if (myArray[y1, x] == rndNum)
                                newNum = false;
                        }

                        for (int x1 = 0; x1 < myArray.GetLength(1); x1++) // check row
                        {
                            if (myArray[y, x1] == rndNum)
                                newNum = false;
                        }

                    } while (!newNum);

                    myArray[y, x] = rndNum;
                }
            }

            PrintArray(myArray);
        }

        public static void PrintArray(int[,] myArray)
        {
            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.Write(myArray[y, x] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
