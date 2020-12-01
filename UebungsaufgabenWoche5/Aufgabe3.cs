using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace UebungsaufgabenWoche5
{
    class Aufgabe3
    {
        public void Abfrage()
        {
            var input = new ConsoleKeyInfo[10];

            for (int i = 0; i < 10; i++)
            {
                input[i] = Console.ReadKey();
            }

            Average(input);
            Median(input);
        }

        public void Average(ConsoleKeyInfo[] input)
        {
            double average = 0;
            int elementCounter = 0;

            foreach(ConsoleKeyInfo element in input)
            {
                average += Double.Parse(element.KeyChar.ToString());
                elementCounter++;
            }
            Console.WriteLine($"Average of your input is: {average /= elementCounter}"); 

            foreach (ConsoleKeyInfo element in input)
            {
                average += Double.Parse(element.KeyChar.ToString());
            }
        }

        public void Median(ConsoleKeyInfo[] input)
        {
            // sorting
            bool sorted = true;
            ConsoleKeyInfo maxValue = input[0];
            int digitCounter = input.Length - 1;
            ConsoleKeyInfo zwErg;

            do
            {
                for (int i = 0; i < input.Length - 1; i++)
                {
                    if (Double.Parse(input[i].KeyChar.ToString()) > Double.Parse(input[i + 1].KeyChar.ToString()) && sorted)
                    {
                        maxValue = input[i];
                        zwErg = input[digitCounter];
                        input[digitCounter] = maxValue;
                        input[i] = zwErg;
                    }
                    else
                    {
                        maxValue = input[i];
                        zwErg = input[digitCounter];
                        input[digitCounter] = maxValue;
                        input[i] = zwErg;
                    }
                }

                for (int i = 0; i < input.Length - 1; i++)
                {
                    if (Double.Parse(input[i].KeyChar.ToString()) < Double.Parse(input[i + 1].KeyChar.ToString()) && sorted)
                        sorted = true;
                    else
                        sorted = false;
                }
                digitCounter--;
            } while (!sorted);
            foreach (ConsoleKeyInfo element in input)
            {
                Console.WriteLine(element);
            }
        }
    }
}
