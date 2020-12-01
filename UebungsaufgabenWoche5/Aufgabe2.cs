using System;
using System.Collections.Generic;
using System.Text;

namespace UebungsaufgabenWoche5
{
    class Aufgabe2
    {
        public void BinaryAddition(int[] num1, int[] num2, bool output = false)
        {
            var num3 = new int[num1.Length];
            int uebertrag = 0;

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                if (uebertrag == 0)
                {
                    if (num1[i] == 1 && num2[i] == 1)
                    {
                        num3[i] = 0;
                        uebertrag = 1;
                    }
                    else if (num1[i] != num2[i])
                        num3[i] = 1;
                } 
                else
                {
                    if (num1[i] == 1 && num2[i] == 1)
                    {
                        num3[i] = 1;
                    }
                    else if (num1[i] != num2[i])
                        num3[i] = 0;
                    else
                    {
                        num3[i] = 1;
                        uebertrag = 0;
                    }
                }
            }

            if (output)
                foreach (int bit in num3)
                {
                    Console.Write(bit);
                }
        }
    }
}
