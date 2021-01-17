using System;

namespace Klausur_WiSe19_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Foto f1 = new Foto("DSC100.jpg", 2.8);
            Foto f2 = new Foto("DSC101.jpg", 5.6, Orientierung.Hoch);
            Foto f3 = new Foto("DSC102.jpg", 11.0);
            Foto[] fotos = { f1, f2, f3 };

            Console.WriteLine($"Bildnummer: {fotos[2].ImageNumber}");
            Console.WriteLine($"Position im Feld: {f2.IndexOf(fotos)}");
            Foto[] teilmenge = Foto.BlendenFilter(fotos, 5.6);

            foreach (var f in teilmenge)
            {
                Console.WriteLine(f.ToString());
            }
        }

        static int TripleInt(int i)
        {
            int counter = 0;

            for (int x = 100; x <= 999; x++)
            {
                if (x % i == 0 || x / i >= 1)
                    counter++;
            }

            return counter;
        }

        static int RowCol(int[,] m, int k)
        {
            try
            {
                var sumX = 0;
                var sumY = 0;

                for (int x = 0; x < m.GetLength(1); x++)
                {
                    sumX += m[k, x];
                }

                for (int y = 0; y < m.GetLength(0); y++)
                {
                    sumY += m[y, k];
                }

                return sumX - sumY;
            }
            catch (IndexOutOfRangeException)
            {
                return 0;
            }
        }
    }
}
