﻿using System;
using System.IO;

namespace Klausur_WiSe15
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1

            Console.WriteLine(RemoveBlanks("Hallo Welt          und hello      World"));

            // 2

            ZiffernZaehlen(1636);

            // 3

            var personen = new Person[2];
            personen[0] = new Person("erster", 243.234, MTyp.Abteilungsleiter, 2131);
            personen[1] = new Person("zweiter", 4564.1, MTyp.Angestellter, 4);

            Console.WriteLine(Person.Gehaltvolumen(personen, MTyp.Abteilungsleiter));

            Console.WriteLine(personen[0].personalnummer);
            Console.WriteLine(personen[1].personalnummer);
            var p1 = new Person("dritter", 451234.1, MTyp.Angestellter);
            Console.WriteLine(p1.personalnummer);


        }

        public static string RemoveBlanks(string s)
        {
            string tmp = "";

            if (s != "" && s != null)
                tmp += s[0];
            else
                return "Uebergebener String war Null bzw. leer!";

            for (int i = 1; i < s.Length; i++)
            {
                if (!(s[i] == ' ' && s[i - 1] == ' '))
                    tmp += s[i];
            }
            return tmp;
        }

        public static void ZiffernZaehlen(int i)
        {
            var myArray = new int[10];

            // max 4 stellen da der konzertsaal 3250 plaetze hat

            myArray[i / 1000]++; // tausender
            myArray[(i % 1000) / 100]++; // hunderter
            myArray[(i % 100) / 10]++; // zehner
            myArray[i % 10]++; // einer - stelle

            for (int r = 0; r < myArray.Length; r++)
            {
                Console.WriteLine($"fuer die {r}er werden {myArray[r]} Schilder benoetigt");
            }
        }

        public static double KundenUmsatz(int id)
        {
            var myReader = new StreamReader(@"irgenteinPfad");
            var line = myReader.ReadLine();

            int aufenthalt = 0;

            while (line != null)
            {
                var currLine = line.Split('\t');
                
                if(Convert.ToInt32(currLine[0]) == id && currLine.Length == 4) // every line without exit time gets skipped
                {
                    int beginn = Convert.ToInt32(currLine[2].Split(':')[0]) * 60 + Convert.ToInt32(currLine[2].Split(':')[1]);
                    int ende = Convert.ToInt32(currLine[3].Split(':')[0]) * 60 + Convert.ToInt32(currLine[3].Split(':')[1]);

                    aufenthalt += ende - beginn;
                }
                line = myReader.ReadLine();
            }
            myReader.Close();
            double betrag = (aufenthalt / 15) * 0.40;

            if (aufenthalt % 15 != 0)
                betrag += 0.40;

            return betrag;
        }
    }
}
