using System;
using System.IO;

namespace Klausur_SoSe17
{
    class Konto
    {
        string name;
        int kontonr;
        double guthaben;

        public Konto(string name, int kontonr, double guthaben) // Konstruktor
        {
            this.name = name;
            this.kontonr = kontonr;
            this.guthaben = guthaben;
        }

        public double Zinsen()   // Zinsen berechnen
        {
            return guthaben * 1.2; // Keine Funktionalitaet in der Aufgabenstellung spezifiziert
        }

        public static void Kontenlesen(out Konto[] konten, out double zinsen)
        {
            var myReader = new StreamReader(@"C:\Users\Chris\source\Prog12020\Klausur_SoSe17\konten.txt");
            var line = myReader.ReadLine();

            konten = new Konto[Convert.ToInt32(line)];
            zinsen = 0;

            int counter = 0;

            while (line != null)
            {
                var currLine = line.Split(';');
                konten[counter] = new Konto(currLine[0], Convert.ToInt32(currLine[1]), Convert.ToDouble(currLine[2].Replace('.', ',')));
                zinsen += konten[counter].Zinsen();

                counter++;
                line = myReader.ReadLine();
            }

            myReader.Close();
        }
    }
}
