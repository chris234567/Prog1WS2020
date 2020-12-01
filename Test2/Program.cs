using System;

namespace Praktikum5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { {1,2 },{3,4 },{5,6 } };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine(arr[i, j]);
                }
            }

        }

        
        
    }
}
