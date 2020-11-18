using System;

namespace DiesDas
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4, b = 5;

            Console.WriteLine(Diesdas(a, b));


        }

        static int Diesdas(int a, int b)
        {
            a += 1;
            b += 1;

            return a & b;
        }
    }
}
