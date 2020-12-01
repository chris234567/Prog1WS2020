using System;
using System.Collections.Generic;
using System.Text;

namespace UebungsaufgabenWoche5
{
    class Aufgabe1
    {
        public void FizzBuzz(int a, int b)
        {
            var myArray = GetArray();
            FizzTheBuzz(ref myArray, b);
        }

        public string[] GetArray()
        {
            return new string[1];
        }

        public void FizzTheBuzz(ref string[] array, int length)
        {
            for (int i = 1; i < length; i++)
            {
                string[] zwErg = array;
                string fizzOrBuzz;

                array = new string[array.Length + 1];

                if (i % 3 == 0 && i % 5 == 0)
                    fizzOrBuzz = "FizzBuzz";
                else if (i % 3 == 0)
                    fizzOrBuzz = "Fizz";
                else if (i % 5 == 0)
                    fizzOrBuzz = "Buzz";
                else
                    fizzOrBuzz = "nothing";

                array[i] = fizzOrBuzz;
                int k = 0;

                foreach (string element in zwErg)
                {
                    array[k] = element;
                    k++;
                }
            }
            foreach (string element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
