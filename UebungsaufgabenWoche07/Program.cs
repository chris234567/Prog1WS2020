using System;

namespace UebungsaufgabenWoche07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Div(5, 2));
            Console.WriteLine();

            var chris = new Student("stade", "chris", 999999, 30);

            chris.Speak();

            Speaker.SayHello("jan");

            Speaker.SayHelloHello(10);

            CheckName("diesisteinname");
        }

        public static void CheckName(string name)
        {
            if (name == "Jan")
                throw new Exception("IMPOSTOR");
            else if (name.Length < 10)
                throw new Exception("Name zu kurz");

            foreach (var character in name)
            {
                int asciiVal = character;

                if (!(asciiVal > 64 || asciiVal < 91) ||
                    !(asciiVal > 96 && asciiVal < 123))
                    throw new Exception("Das ist kein Name");
            }

            Console.WriteLine(name.ToUpper());
        }
    }
}
