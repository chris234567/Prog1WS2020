using System;
using System.IO;

namespace Klausur_WiSe_18_19
{
    public class Faehre
    {
        public string von;
        public string nach;
        public int abfahrtszeit;
        public string preis;

        public Faehre(string von, string nach, string abfahrtszeit, string preis)
        {
            this.von = von;
            this.nach = nach;
            this.abfahrtszeit = Int32.Parse(abfahrtszeit.Split(':')[0]) * 60 + Int32.Parse(abfahrtszeit.Split(':')[1]);
            this.preis = preis;
        }
    }
    class Dateiverarbeitung
    {
        public static void NaechsteFaehren(string ort, int std, int min)
        {
            var myReader = new StreamReader(@"verzeichnis/Fahrplan.txt");

            var line = myReader.ReadLine();
            int counter = 0;

            while (line != null)
            {
                counter++;
                line = myReader.ReadLine();
            }
            Faehre[] naechsteFaehren = new Faehre[counter];

            counter = 0; // counter gets recycled
            myReader = new StreamReader(@"verzeichnis/Fahrplan.txt");
            line = myReader.ReadLine();

            while (line != null)
            {
                var l = line.Split('|', ' ');
                if (Int32.Parse(l[0].Split(':')[0]) * 60 + Int32.Parse(l[0].Split(':')[1]) > std * 60 + min)
                    naechsteFaehren[counter] = new Faehre(l[1], l[3], l[0], l[4]);
                counter++;

                line = myReader.ReadLine();
            }
            myReader.Close();

            foreach(var faehre in naechsteFaehren)
            {
                if (faehre != null)
                    Console.WriteLine($"Faehre von {faehre.von} nach {faehre.nach}: {faehre.abfahrtszeit} ${faehre.preis} ");
            }
        }
    }
}
