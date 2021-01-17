using System;
using System.IO;

namespace Klausur_WiSe16_17
{
    class VokabelManager
    {
        string[] vokPaare = new string[300]; // Speicher für die Vokabelpaare OHNE die Abschnittnamen
        string[] absNamen = new string[10]; // Feld für die Abschnittnamen
        int[] absAnf = new int[10]; // Indexfeld, in dem die Abschnittanfänge in vokPaare gemerkt werden
        int anzVok = 0; // Anzahl der im Vokabelfeld gespeicherten Vokabeln
        int anzAbs = 0; // Anzahl der Vokabelabschnitte

        public void VokabelnLesen(string dateiname) 
        {
            var myReader = new StreamReader(dateiname);
            var line = myReader.ReadLine();
            int abschittNr = 0;
            int vokabelPaarNur = 0;

            while (line != null)
            {
                if (line.Contains('#')) // ist abschnitt
                {
                    absNamen[abschittNr] = line.Substring(1);
                    abschittNr++;
                    anzAbs++;
                    absAnf[abschittNr] = abschittNr + 1; // neue vokabeln starten unmittelbar nach abschnittsdeklaration  
                }
                else // ist vokabelpaar
                {
                    vokPaare[vokabelPaarNur] = line;
                    anzVok++;
                }
                line = myReader.ReadLine();
            }
            myReader.Close();
        }

        public void Suchen(string suchtext) 
        {
            for (int i = 0; i < vokPaare.Length; i++)
            {
                if (vokPaare[i].Contains(suchtext))
                {
                    for (int r = absAnf.Length - 1; r >= 0; r--)
                    {
                        if(i >= absAnf[r])
                        {
                            Console.WriteLine($"Vokabel aus Abschitt: {absNamen[r]}");
                            Console.WriteLine(vokPaare[i]);
                            break;
                        }
                    }
                }
            }
        }
    }
}
