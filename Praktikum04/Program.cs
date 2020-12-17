using System;
using System.ComponentModel.DataAnnotations;

namespace Praktikum4
{
    class Program
    {
        static void Main(string[] args)
        {
            int credit1 = 10;
            int credit2 = 10;
            Play(ref credit1, ref credit2);
            
            Console.WriteLine("\n Endergebnisse:");
            Console.WriteLine($" Spieler 1 hat aus 10 Jetons {credit1} gemacht.");
            Console.WriteLine($" Spieler 2 hat aus 10 Jetons {credit2} gemacht.");
        }

        //Spielmethode
        static void Play(ref int credit1, ref int credit2)
        {
            int sumSpieler1;
            int sumSpieler2;
            bool play = true;

            while(play) 
            {
                Console.WriteLine("\n ~ ~ Spieler 1:");

                int einsatz1 = stakes(credit1, ref play);
                if (play) // Geht Spiel weiter bzw. wurde 0 gesetzt?
                {
                    Console.WriteLine("\n ~ ~ Spieler 2:");

                    int einsatz2 = stakes(credit2, ref play);
                    
                    if (play) // nochmal: Geht Spiel weiter bzw. wurde 0 gesetzt?
                    {
                        Console.WriteLine("\n Spieler 1:");

                        cards(out sumSpieler1);

                        Console.WriteLine("\n Spieler 2:");

                        cards(out sumSpieler2);

                        croupier(sumSpieler1, sumSpieler2, ref credit1, ref credit2, einsatz1, einsatz2);

                        Console.WriteLine(" Runde beendet");

                    }

                }
                
            }
            
        }

        // Methode zur Einsatzabfrage
        static int stakes(int credit, ref bool play)
        {            
            Console.Write(" Bitte gib deinen Einsatz an (0 um das Spiel zu beenden):");

            int einsatz;
            bool konvertierbar = Int32.TryParse(Console.ReadLine(), out einsatz);

            while (!konvertierbar)
            {
                Console.WriteLine(" Eingabe kann nicht konvertiert werden");
                Console.Write(" Dein Einsatz: ");

                konvertierbar = Int32.TryParse(Console.ReadLine(), out einsatz);
            }

            do
            {
                if (einsatz == 0)
                {
                    play = false;

                }
                else
                {
                    if (einsatz < 1 && konvertierbar)
                    {
                        Console.WriteLine(" Einsatz ist zu klein!");
                        Console.WriteLine($" Du musst mindestens 1 und kannst max. {credit} setzen.");
                        Console.Write($" Dein Einsatz: ");
                        konvertierbar = Int32.TryParse(Console.ReadLine(), out einsatz);

                    }
                    else if (einsatz > credit && konvertierbar)
                    {
                        Console.WriteLine(" Einsatz ist zu gross!");
                        Console.WriteLine($" Du musst mindestens 1 und kannst max. {credit} setzen.");
                        Console.Write($" Dein Einsatz: ");
                        konvertierbar = Int32.TryParse(Console.ReadLine(), out einsatz);

                    }
                    else if (!konvertierbar)
                    {
                        Console.WriteLine(" Eingabe kann nicht konvertiert werden");
                        Console.Write(" Dein Einsatz: ");
                        konvertierbar = Int32.TryParse(Console.ReadLine(), out einsatz);

                    }
                    
                }

            } while (einsatz < 0 || einsatz > credit);

            return einsatz;

        }

        // Methode zum Kartenziehen der Spieler
        static void cards(out int sum)
        {
            Random zufall = new Random();

            string drawer = "player";
            bool weiter = true;
            sum = 0;

            for (int i = 0; i < 2; i++) // setzt zu Beginn 2 Karten
            {
                if (sum < 21)
                {
                    randomCard(drawer, ref sum);

                }

            }

            if (sum < 21)
            {
                do
                {
                    Console.Write($" Noch eine Karte? (j|J fuer Ja eingeben)");
                    char eingabe = char.Parse(Console.ReadLine());

                    if (eingabe == 'j' || eingabe == 'J') // setzt so viele Karten wie man moechte solange Summe der Karten unter 21
                    {
                        randomCard(drawer, ref sum);

                    }
                    else
                    {
                        weiter = false; // bei eingabe != j wird die Schleife abgebrochen

                    }

                } while (weiter && sum < 21);

            }

        }

        // Bestimmt zufaellige Karte und ihren entsprechenden Wert
        static void randomCard(string drawer, ref int sum)
        {
            Random zufall = new Random();

            int eineKarte = zufall.Next(1, 14);

            if (eineKarte == 1 && drawer == "player")
            {
                if (sum + 11 < 22)
                    sum += 11;
                else
                    sum += 1;

            } else
            {
                sum += eineKarte;

            }

            switch (eineKarte)
            {
                case 11:
                    Console.WriteLine($" Karte:  B, Gesamt:  {sum}");
                    break;
                case 12:
                    Console.WriteLine($" Karte:  D, Gesamt:  {sum}");
                    break;
                case 13:
                    Console.WriteLine($" Karte:  K, Gesamt:  {sum}");
                    break;
                default:
                    Console.WriteLine($" Karte:  {eineKarte}, Gesamt:  {sum}");
                    break;

            }

        }

        // Methode zur Ermittlung der Gewinner
        static void winner(int sumCroupier, string player, int sumSpieler, ref int credit, ref int einsatz)
        {
            if (sumSpieler > 21)
            {
                credit -= einsatz;

                Console.WriteLine($" {player} hat verloren. Jetons jetzt: {credit}");

            }
            else if (sumSpieler > sumCroupier)
            {
                credit += einsatz;

                Console.WriteLine($" {player} hat gewonnen. Jetons jetzt: {credit}");

            }
            else
            {
                credit -= einsatz;

                Console.WriteLine($" {player} hat verloren. Jetons jetzt: {credit}");

            }
        }

        // Gewinntestung + Croupier zieht
        static void croupier(int sumSpieler1, int sumSpieler2, ref int credit1, ref int credit2, int einsatz1, int einsatz2)
        {
            int sumCroupier = 0;
            string drawer = "croupier";

            Console.WriteLine("\n Croupier zieht:");

            while (!(sumCroupier > 16)) // computer zieht bis summe der karten ueber 16
            {
                randomCard(drawer, ref sumCroupier);

            }

            // Gewinnpruefung

            string player;

            player = "Spieler 1";
            winner(sumCroupier, player, sumSpieler1, ref credit1, ref einsatz1);

            player = "Spieler 2";
            winner(sumCroupier, player, sumSpieler2, ref credit2, ref einsatz2);

        }

    }

}
