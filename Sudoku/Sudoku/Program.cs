using System;
using System.IO;

namespace Sudoku
{
    class Sudoku
    {
        byte[,] array;

        public Sudoku(byte[,] array = null)
        {
            this.array = new byte[9, 9];

            if (array == null) // Kein Array angegeben
            {
                return;
            }
            else if (array.GetLength(0) > 9 || array.GetLength(1) > 9) //Zu groß
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        this.array[i, j] = array[i, j];
                    }
                }
            }
            else //Standard
            {
                this.array = (byte[,])array.Clone();
            }
        }

        public void Print()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public bool SetzeFeld(int x, int y, byte b)
        {
            if (x < 1 || x > 9 || y < 1 || y > 9 || b < 1 || b > 9)
            {
                throw new ArgumentException("invalid number");
            }

            array[y - 1, x - 1] = b;
            return true;
        }

        private int[] zeilenZiffernZaehlen(int zeile)
        {
            var nums = new int[10];

            for (int i = 0; i < array.GetLength(1); i++)
            {
                if (array[zeile - 1, i] != 0)
                    nums[array[zeile - 1, i] - 1]++;
            }

            return nums;
        }

        private int[] spaltenZiffernZaehlen(int spalte)
        {
            var nums = new int[10];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, spalte - 1] != 0)
                    nums[array[i, spalte - 1] - 1]++;
            }

            return nums;
        }

        private static bool ziffernFehler(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 1)
                    return false;
            }

            return true;
        }

        public bool ZeilenFehler(int zeile)
        {
            return !ziffernFehler(zeilenZiffernZaehlen(zeile));
        }

        public bool SpaltenFehler(int spalte)
        {
            return !ziffernFehler(spaltenZiffernZaehlen(spalte));
        }

        public bool BlockFehler(int x, int y)
        {
            var pos = new int[] { y == 1 ? 0 : y == 2 ? 3 : 6, x == 1 ? 0 : y == 2 ? 3 : 6 };
            var block = new byte[3, 3];

            for (int y1 = pos[0]; y1 < pos[0] + 3; y1++)
            {
                for (int x1 = pos[1]; x1 < pos[1] + 3; x1++)
                {
                    block[y1 - pos[0], x1 - pos[1]] = array[y1, x1];
                }
            }

            var Block = new Sudoku(block);

            for (int i = 1; i < 4; i++)
            {
                if (Block.SpaltenFehler(i))
                    return true;

                if (Block.ZeilenFehler(i))
                    return true;
            }

            return false;
        }

        public bool Fehler
        {
            get
            {
                for (int i = 1; i <= array.GetLength(0); i++)
                {
                    if (ZeilenFehler(i) || SpaltenFehler(i) || BlockFehler(i / 3, i % 3))
                        return true;
                }

                return false;
            }
        }

        public bool Unvollstaendig
        {
            get
            {
                int counter1 = 0;
                int counter2 = 0;

                for (int y = 0; y < array.GetLength(0); y++)
                {
                    for (int x = 0; x < array.GetLength(1); x++)
                    {
                        if (array[y, x] == 0)
                            counter1++; // counts empty positions
                        counter2++; // counts all positions
                    }
                }

                return counter1 == counter2;
            }
        }

        public Sudoku(Sudoku instance)
        {
            array = (byte[,])instance.array.Clone();
        }

        public bool IstGleich(Sudoku instance)
        {
            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    if (array[y, x] != instance.array[y, x])
                        return false;
                }
            }

            return true;
        }

        public static Sudoku LeseDatei(string path)
        {
            var myReader = new StreamReader(path);
            var line = myReader.ReadLine().Split(' ');
            int dim = line.Length;

            var array = new byte[dim, dim];

            myReader = new StreamReader(path);

            for (int y = 0; y < dim; y++)
            {
                line = myReader.ReadLine().Split(' ');

                for (int x = 0; x < dim; x++)
                {
                    if (line[x] == ".")
                        array[y, x] = 0;
                    else
                        array[y, x] = Convert.ToByte(line[x]);
                }
            }

            myReader.Close();

            return new Sudoku(array);
        }

        public void SpeichernUnter(string path)
        {
            var myWriter = new StreamWriter(path, false);

            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    myWriter.Write(array[y, x]);
                }

                myWriter.WriteLine();
            }

            myWriter.Close();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Teil 1
            byte[,] Beispiel = {
                { 0,3,0, 0,0,0, 0,0,0 }, //0
                { 0,0,0, 1,9,5, 0,0,0 },
                { 0,0,8, 0,0,0, 0,6,0 }, // 2
                { 8,0,0, 0,6,0, 0,0,0 }, //3
                { 4,0,0, 8,0,0, 0,0,1 },
                { 0,0,0, 0,2,0, 0,0,0 }, // 5
                { 0,6,0, 0,0,0, 2,8,0 }, //6
                { 0,0,0, 4,1,9, 0,0,5 },
                { 0,0,0, 0,0,0, 0,7,0 } // 8
            };

            Sudoku s = new Sudoku(Beispiel);
            Sudoku t = new Sudoku();

            s.Print();
            t.Print();

            #endregion
            #region Teil 2

            Console.WriteLine("Setze 4 in das 3. Feld der ersten Zeile:");
            s.SetzeFeld(3, 1, 4);
            s.Print();

            #endregion
            #region Teil 3

            Console.WriteLine("Zeilen:");
            for (int i = 1; i <= 9; i++)
                Console.WriteLine("{0} {1}", i, s.ZeilenFehler(i) ? "Fehler" : "OK");

            #endregion
            #region Teil 4

            Console.WriteLine("Spalten");
            for (int i = 1; i <= 9; i++)
                Console.WriteLine("{0} {1}", i, s.SpaltenFehler(i) ? "Fehler" : "OK");
            Console.WriteLine("Blöcke:");
            for (int i = 1; i <= 3; i++)
                for (int j = 1; j <= 3; j++)
                    Console.WriteLine("{0}|{1} {2}", i, j, s.BlockFehler(i, j) ? "Fehler" : "OK");

            #endregion
            #region Teil 5

            if (s.Fehler)
                Console.WriteLine("Fehlerhaft!");
            else
                Console.WriteLine("Fehlerfrei");

            #endregion
            #region Teil 6

            t = new Sudoku(s);

            Console.WriteLine("t == s         : {0}", (t == s) ? "JA" : "NEIN");
            Console.WriteLine("t.IstGleich(s) : {0}", (t.IstGleich(s)) ? "JA" : "NEIN");

            t.SetzeFeld(1, 1, 5);
            Console.WriteLine("t neu:");
            t.Print();
            Console.WriteLine("t.IstGleich(s) : {0}", (t.IstGleich(s)) ? "JA" : "NEIN");

            #endregion
            #region Teil 7

            Console.WriteLine("Datei lesen:");
            Sudoku u = Sudoku.LeseDatei(@"..\..\..\beispiel.sudoku");

            u.Print();
            if (u.Fehler)
                Console.WriteLine("Fehlerhaft!");
            else
                Console.WriteLine("Fehlerfrei");

            #endregion
            #region Teil 8

            Console.WriteLine("Datei speichern:");
            s.SpeichernUnter(@"..\..\..\mein.sudoku");

            #endregion
        }
    }
}

