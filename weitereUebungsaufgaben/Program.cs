using System;

namespace weitereUebungsaufgaben
{
    class Program
    {
        static void Main(string[] args)
        {
            //aufgabe1();

            //aufgabe2();

            aufgabe3();
        }

        static void aufgabe1()
        {
            int[] grades = new int[10];

            Console.WriteLine(" Bitte Noten eingeben:");

            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = Int32.Parse(Console.ReadLine()); //mit foreach gehts nicht?!

            }

            Console.WriteLine($" Der Durchschnitt dieser Noten ist: {average(grades)}");
            Console.ReadLine();

        }

        static double average(int[] grades)
        {
            int sum = 0;
            int one = 0, two = 0, three = 0, four = 0, five = 0, six = 0;

            foreach (int grade in grades)
            {
                sum += grade;

                switch (grade)
                {
                    case 1: one += 1; break;
                    case 2: two += 1; break;
                    case 3: three += 1; break;
                    case 4: four += 1; break;
                    case 5: five += 1; break;
                    case 6: six += 1; break;

                }

            }

            Console.WriteLine(" Folgende Noten wurden eingegeben:");
            Console.WriteLine($" 1: {one} mal\n 2: {two} mal\n 3: {three} mal\n 4: {four} mal\n 5: {five} mal\n 6: {six} mal\n");

            return (double) sum / grades.Length;

        }

        static void aufgabe2()
        {
            string brackets = "(()()())())))()()()()()()()()))))))((())))(()()()())))()((((()))()())))))((()()()())))))()(()()((()())))))))))))))((()()()()()()((((()()())))(((()()((()()(((()))()))()()()()()())))))))((()())(()(((())))))))))(((((((()()(((((()))())()())()())()()()()()()()))()((((())()())())(()))))()()()(()))())))))))))))))))))))))))))))))))))))))))))((((()()((((((()(((()()()())))(((((((((((((((()()()()((((((()()()()())(((((((((()()))()()(((((((()())((";
            int value = 0;

            bracketCounter(brackets, ref value);

            Console.WriteLine(value);
        }

        static void bracketCounter(string brackets, ref int value)
        {
            foreach (int element in brackets)
            {
                if (element == '(')
                    value += 1;
                else
                    value -= 1;

            }
            
        }

        static void aufgabe3()
        {

        }
    }

}
