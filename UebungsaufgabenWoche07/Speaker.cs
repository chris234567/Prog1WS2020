using System;
using System.Collections.Generic;
using System.Text;

namespace UebungsaufgabenWoche07
{
    class Speaker
    {
        public static void SayHello(string name)
        {
            Console.WriteLine($"Hallo, {name}. Wie geht es dir heute?\nWarum hast du so einen kurzen Namen?");
        } 

        public static void SayHelloHello(int num = 4)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("hallo");
            }
        }
    }
}
