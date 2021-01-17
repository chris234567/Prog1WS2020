using System;

namespace Klausur_WiSe_18_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Minima(new int[] { 10, 1, 20, 5, 4, 11, 3, 7, 6 });

            //string num = Addiere("42", "29");

            //Console.WriteLine(num[1]);

            var bug1 = new Bug("Fehler A", Status.Offen);
            var bug2 = new Bug("Fehler C");
            var bug3 = new Bug("Fehler A", Status.Geschlossen);

            Bug.DuplikateAusgeben(bug1, bug2, bug3);
        }

        public static void Minima(int[] array)
        {
            for (int i = 1; i < array.Length - 1; i++)// starts and ends one index later/earlier because the edge values dont have neighbours
            {
                if (array[i - 1] > array[i] ? array[i] < array[i + 1] : false)
                    Console.WriteLine(array[i]);
            }
        }

        //public static string Addiere(string a, string b)
        //{
        //    int value = 0;
        //    bool uebertrag = false;
        //    char[] num = new char[Convert.ToInt32(a[0]) + Convert.ToInt32(b[0]) > 5 ? a.Length + 1 : a.Length];

        //    for (int i = a.Length - 1; i >= 0; i--) // a.Length == b. Length
        //    {
        //        value = uebertrag ? a[i] + b[i] + 1 : a[i] + b[i];

        //        uebertrag = value > 9;

        //        num[i] = value < 9 ? Convert.ToChar(value.ToString()) : Convert.ToChar((value - 9).ToString());
        //    }
        //    foreach (var item in num)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    return num.ToString();

        //    //////////////////////////////////////////////////
        //}
    }
}
