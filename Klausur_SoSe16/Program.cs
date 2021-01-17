using System;
using System.IO;

namespace Klausur_SoSe16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(AltQuersumme(1048576));

            // 4

            var uhr1 = new Uhr(3);
            var uhr2 = new Uhr(23, 59);

            var uhr3 = Uhr.Spaeter(uhr1, uhr2);

            Console.WriteLine(uhr3.ToString());

            uhr3.Minute += 1; // Ueberlauf
            uhr3.Stunde += 1; // Ueberlauf
        }

        public static int AltQuersumme(int i)
        {
            int erg = 0;
            string s = i.ToString();

            for (int r = 0; r < s.Length; r++)
            {
                int vz = r % 2 == 0 ? 1 : -1;
                erg += vz * (Convert.ToInt32(s[r]) - 48); // minus 48 because of ascii values
            }
            return erg;
        }

        public static double[] Mittelwerte(double[,] array)
        {
            var erg = new double[array.GetLength(0)];
            for (int y = 0; y < array.GetLength(0); y++)
            {
                double werte = 0;
                double anzahl = 0;

                for (int x = 0; x < array.GetLength(1); x++)
                {
                    werte += array[y, x];
                    anzahl++;
                }
                erg[y] = werte / anzahl;
            }
            return erg;
        }

        public static (string, double) ReadFile(string date)
        {
            var myReader = new StreamReader(@"irgenteinPfad");
            var line = myReader.ReadLine();

            while (line != null)
            {
                var currLine = line.Split('\t');
                if (currLine[0] == date)
                {
                    double min = 0;
                    int index = 0;

                    for (int i = 2; i < currLine.Length; i += 2) // every second value starting from index 1 is a tidal value
                    {
                        if (Convert.ToDouble(currLine[i]) < min)
                        {
                            min = Convert.ToDouble(currLine[i]);
                            index = i;
                        }
                    }
                    return (currLine[index - 1], min);
                }

                line = myReader.ReadLine();
            }
            myReader.Close();

            return ("", 0.0);
        }
    }
}
