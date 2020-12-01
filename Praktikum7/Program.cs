using System;

namespace Praktikum7
{
    class Program
    {
        const string zeichenvorrat = " ............";
        const int breite = 95;
        const int hoehe = 30;
        const double minX = -2;
        const double maxX = 0.8;
        const double minY = -1.5;
        const double maxY = 1.5;
        const double xSchritt = (maxX - minX) / breite;
        const double ySchritt = (maxY - minY) / hoehe;

        static void Main(string[] args)
        {
            var charArray2D = new char[hoehe, breite];

            for (int i = 0; i < charArray2D.GetLength(0); i++)
            {
                for (int k = 0; k < charArray2D.GetLength(1); k++)
                {
                    charArray2D[i, k] = zeichenvorrat[Mandel(i, k)];
                }
            }
            Output(charArray2D);

            charArray2D = Mirror(charArray2D);

            Output(charArray2D);

            Random rnd = new Random();
            
            for (int i = 0; i < rnd.Next(30); i++) // scrolls randomly between 0 and 30 times
                charArray2D = Scroll(charArray2D);

            Output(charArray2D); 
        }

        /// <summary>
        /// Berechnung der Folge z = z*z + c
        /// </summary>
        /// <param name="zeile">Zeile</param>
        /// <param name="spalte">Spalte</param>
        /// <returns>0, falls c Element der Mandelbrot-Menge; sonst: Anzahl der Iterationen, bis |z| > 2</returns>
        static int Mandel(int zeile, int spalte)
        {
            // Die entsprechende komplexe Zahl c:
            double x = minX + spalte * xSchritt;
            double y = minY + zeile * ySchritt;
            System.Numerics.Complex c = new System.Numerics.Complex(x, y);

            // Folge berechnen:
            System.Numerics.Complex z = c;
            for (int i = 0; i < zeichenvorrat.Length; i++)
            {
                if (z.Magnitude > 2)
                {
                    // Die Folge ist nicht beschränkt
                    // => c ist nicht Element der Mandelbrot-Menge
                    return i;
                }
                z = z * z + c;
            }
            // Die Folge ist beschränkt (|z| bleibt <= 2)
            // => c ist Element der Mandelbrot-Menge
            return 0;
        }
        /// <summary>
        /// Prints a 2d Array to the console.
        /// </summary>
        /// <param name="charArray2D"></param>
        static void Output(char[,] charArray2D)
        {
            for (int i = 0; i < charArray2D.GetLength(0); i++) // goes through every element of the array
            {
                for (int k = 0; k < charArray2D.GetLength(1); k++)
                {
                    Console.Write(charArray2D[i, k]);
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Mirrors a matrix along the perpendicular bisector.
        /// </summary>
        /// <param name="charArray2D"></param>
        /// <returns></returns>
        static char[,] Mirror(char[,] charArray2D)
        {
            var newCharArray2D = new char[charArray2D.GetLength(0), charArray2D.GetLength(1)];

            for (int i = 0; i < charArray2D.GetLength(0); i++) // goes through every element of the array
            {
                for (int k = 0; k < charArray2D.GetLength(1); k++)
                {
                    newCharArray2D[i, k] = charArray2D[i, charArray2D.GetLength(1) - (k + 1)];
                }
            }
            return newCharArray2D;
        }
        /// <summary>
        /// Shifts every row of an array up by one.
        /// </summary>
        /// <param name="charArray2D"></param>
        /// <returns></returns>
        static char[,] Scroll(char[,] charArray2D)
        {
            var newCharArray2D = new char[charArray2D.GetLength(0), charArray2D.GetLength(1)]; // ich hoffe fuer diesen loesungsweg gibt es keinen punktabzug. wollte nur einfach nicht den algorithmus aus der aufgabenstelling 1 zu 1 uebernehmen

            for (int i = 0; i < charArray2D.GetLength(0); i++) // goes through every element of the array
            {
                for (int k = 0; k < charArray2D.GetLength(1); k++)
                {
                    if (i == charArray2D.GetLength(0) - 1) // copies last row
                        newCharArray2D[i, k] = charArray2D[0, k]; 
                    else 
                        newCharArray2D[i, k] = charArray2D[i + 1, k]; // copies every row of the original array to the new one, shifted by one
                }
            }
            return newCharArray2D;
        }
    }
}
