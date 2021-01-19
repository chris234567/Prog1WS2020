using System;
using System.IO;

namespace _3594519_Aufgabe5
{
    ////////////////////////////////////////////////////////////////////////////////
    /// Aufgabe 5 - Dateiauswertung
    /// 
    /// Name: Christoph Stade
    /// Matrikelnummer: 3594519
    /// 
    /// Erreichte Punktzahl:
    ////////////////////////////////////////////////////////////////////////////////

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dateiauswertung! VIEL ERFOLG!");
            Console.WriteLine("Bitte oben Name und Matrikelnummer eintragen!!!");

            var myReader = new StreamReader(@"..\..\..\Wetterdaten.txt");
            var line = myReader.ReadLine(); // erste zeile mit index angaben
            var sturmTage = 0;
            var windIndex = 0;
            var sturmBeginn = "";
            var firstIteration = true;
            bool stuermisch = false;

            for (int i = 0; i < line.Split(';').Length; i++)
            {
                if (line.Split(';')[i].Contains("WINDSPITZE_MAXIMUM")) // bei WINDGESCHWINDIGKEIT kommen sinnvollere strumzeiten raus meiner meinung nach ( fehler in der angabe? )
                    windIndex = i;
            }

            while (line != null)
            {
                var currLineSplit = line.Split(';');

                if (!firstIteration && Double.Parse(currLineSplit[windIndex]) >= 20.0) // erste zeile beinhaltet keine wetterdaten daher wird (potentiell problematische konvertierung) uebersprungen
                    sturmTage++;

                else
                {
                    if (sturmTage >= 3)
                    {
                        Console.WriteLine($"{sturmTage} Tage Sturm ab dem {sturmBeginn}");
                        stuermisch = true;
                    }

                    // reset

                    sturmTage = 0; 
                    sturmBeginn = "";
                }

                if (sturmTage == 1) // ein potentieller sturm beginnt
                    sturmBeginn = $"{currLineSplit[1].Substring(6, 2)}.{currLineSplit[1].Substring(4, 2)}.{currLineSplit[1].Substring(0, 4)}";

                firstIteration = false;
                line = myReader.ReadLine();
            }
            if (!stuermisch)
                Console.WriteLine("Es gab im Aufzeichnungszeitraum keine Stuerme.");

            myReader.Close();
        }
    }
}
