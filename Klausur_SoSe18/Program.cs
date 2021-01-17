using System;
using System.IO;
using System.Globalization;


namespace ProbeKlausur_SoSe_18
{
    class Program
    {
        public enum Eigenschaft
        {
            gerade,
            ungerade,
            gemischt,
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Gerade(new int[] { 5, 7, 9, 20 }).ToString());
            Console.WriteLine(Reihe());
            Log(0.437, 1.227, "init", "memory");

            // 4 Menge

            var array = new Menge[2];

            Menge.Suche(array, 2);
        }

        public static Eigenschaft Gerade(int[] array)
        {
            int gerade = 0;
            int unGerade = 0;

            for (int num = 0; num < array.Length; num++)
            {
                gerade += array[num] % 2 == 0 ? 1 : 0;
                unGerade += array[num] % 2 != 0 ? 1 : 0;
            }
            return gerade == array.Length && unGerade != array.Length ? Eigenschaft.gerade :
                    gerade != array.Length && unGerade == array.Length ? Eigenschaft.ungerade :
                    Eigenschaft.gemischt;
        }

        public static double Reihe()
        {
            double reihe = 0;
            double l = 2;

            while (true)
            {
                int vorzeichen = l % 2 == 0 ? 1 : -1;
                reihe += vorzeichen * (1 / ((l - 1) * l));
                if (1 / ((l - 1) * l) < 0.00001)
                    break;
                l++;
            }
            return reihe;
        }

        public static void Log(double start, double end, params string[] array)
        {
            var myReader = new StreamReader(@"C:\Users\Chris\source\Prog12020\ProbeKlausur_SoSe_18\kernel.log.txt");
            var line = myReader.ReadLine();

            while (line != null)
            {
                NumberFormatInfo provider = new NumberFormatInfo();
                double time = Convert.ToDouble(line.Substring(1, 12), provider); // zaehlt . als reservierte stelle?! angabe unklar

                if (time > start && time < end)
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (line.Contains(array[i]))
                        {
                            Console.WriteLine(line);
                            break;
                        }
                    }
                line = myReader.ReadLine();
            }
            myReader.Close();
        }

        public static int GetIndex(string s, char r)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == r)
                    return i;
            }
            return -1;
        }
    }
}
