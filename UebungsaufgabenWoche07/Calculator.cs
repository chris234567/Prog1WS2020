using System;
using System.Collections.Generic;
using System.Text;

namespace UebungsaufgabenWoche07
{
    class Calculator
    {
        public static int Add(int x , int y)
        {
            return x + y;
        }
        public static int Sub(int x, int y)
        {
            return x - y;
        }
        public static int Mult(int x, int y)
        {
            return x * y;
        }
        public static double Div(int x, int y) // double for decimal numbers
        {
            return (double)x / (double)y;
        }
    }
}
