using System;
using System.Collections.Generic;
using System.Text;

namespace Prog1Uebung09122020
{
    class Medium
    {
        public static void Main(string[] args)
        {
            var array = new Medium[] { new Medium("Medium1", Typ.Audio), new Medium("Medium2") };
            var array2 = Statistics(array);
            foreach (var element in array2)
            {
                Console.WriteLine(element);
            }
        }
        public string Name
        { get; private set; }
        int serNr;
        public static int Counter
        { get; private set; }
        Typ a;
        public enum Typ { Foto, DVD, mp4, Audio };
        public Medium(string name, Typ t = Typ.Foto)
        {
            this.Name = name;
            this.a = t;
            serNr = Counter++;
        }
        public int[] Statistics(Medium[] array)
        {
            var temp = new int[4];
            foreach (var element in array)
            {
                int r = (int)element.a;
                temp[r] += 1;
            }
            return temp;
        }
        public Medium Search(Medium[] array, string text)
        {
            foreach (var element in array)
            {
                if(element.Name.Contains(text))
                    return element;
            }
            return null;
        }
    }
}
