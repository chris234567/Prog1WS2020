using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;

namespace Praktikum3
{
    class Program
    {
        static void Main(string[] args)
        {
            int spielerGuthaben = 10;
            int sumSpieler;
            bool weiter = true;
            int sumComputer;
            char nochmal;
            int einsatz;

            do
            {
                // regionen einteilung zur uebersicht
                #region SpielerSchleife 
                sumSpieler = 0; // reset Kartensumme fuer naechste Runde
                sumComputer = 0;

                Console.WriteLine($" Dein Guthaben: {spielerGuthaben} Chips.");
                Console.Write($" Dein Einsatz: ");

                einsatz = int.Parse(Console.ReadLine());

                while (einsatz < 1 || einsatz > spielerGuthaben) // erfraegt Einsatz zwischen 1 und 10
                {
                    Console.WriteLine(" Du musst mindestens 1 und kannst max. alle Chips setzen.");
                    Console.Write($" Dein Einsatz: ");
                    einsatz = int.Parse(Console.ReadLine());

                }

                Random zufall = new Random();

                for (int i = 0; i < 2; i++) // setzt zu Beginn 2 Karten
                {
                    int eineKarte = zufall.Next(2, 12);
                    sumSpieler += eineKarte;
                    Console.WriteLine($" Karte:  {eineKarte}, Gesamt:  {sumSpieler}");

                }

                do
                {
                    Console.Write($" Noch eine Karte (j/n)? ");
                    char eingabe = char.Parse(Console.ReadLine());

                    if (eingabe == 'j') // setzt so viele Karten wie man moechte solange Summe der Karten unter 21
                    {
                        int eineKarte = zufall.Next(2, 12);
                        sumSpieler += eineKarte;
                        Console.WriteLine($" Karte:  {eineKarte}, Gesamt:  {sumSpieler}");

                    }
                    else
                    {
                        weiter = false; // bei eingabe != j wird die Schleife abgebrochen
                    }

                } while (weiter && sumSpieler < 21); // auch wenn der Spieler mehr als 20 hat wird abgebrochen
                #endregion

                #region Gewinner & ComputerSchleife
                if (sumSpieler > 21) // wenn spieler meh als 21 hat gewinnt computer automatisch, anderweitig werden weitere gewinnbedingungen geprueft
                {
                    spielerGuthaben -= einsatz;

                    Console.WriteLine("\n Ich habe gewonnen.");
                    Console.WriteLine($"\n Dein Guthaben: {spielerGuthaben} Chips.");

                }
                else
                {
                    Console.WriteLine("\n Ich bin dran.");

                    while (!(sumComputer > 16)) // computer zieht bis summe der karten ueber 16
                    {
                        int eineKarte = zufall.Next(2, 12);
                        sumComputer += eineKarte;
                        Console.WriteLine($" Karte:  {eineKarte}, Gesamt:  {sumComputer}");

                    }

                    if (sumComputer > 21 || sumSpieler > sumComputer) // einziger gewinnfall des spielers bei groesserer summe als computer unter 21 oder computer uebertrifft 21
                    {
                        spielerGuthaben += einsatz;

                        Console.WriteLine("\n Du hast gewonnen.");
                        Console.WriteLine($"\n Dein Guthaben: {spielerGuthaben} Chips.");

                    }
                    else
                    {
                        spielerGuthaben -= einsatz; // in allen anderen faellen gewinnt der computer

                        Console.WriteLine("\n Ich habe gewonnen.");
                        Console.WriteLine($"\n Dein Guthaben: {spielerGuthaben} Chips.");
                    }
                }
                #endregion

                Console.WriteLine(" Nochmal (j/n)?");
                nochmal = char.Parse(Console.ReadLine());

                Console.Clear(); // leert die Konsole nach jedem Durchlauf (finde ich aestetischer:))

            } while ((nochmal == 'j') && (spielerGuthaben != 0));

        }
    }
}
