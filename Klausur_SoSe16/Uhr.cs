using System;

namespace Klausur_SoSe16
{
    class Uhr
    {
        private int stunde;
        private int minute;

        public int Stunde
        {
            get
            {
                return stunde;
            }
            set
            {
                stunde = value;

                if (stunde > 23)
                    throw new Exception("Achtung! Ueberlauf");
            }
        }

        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                minute = value;

                if (minute > 59)
                {
                    Stunde += Minute / 59;
                    Minute = Minute - 59;
                }
            }
        }

        public Uhr(int stunde = 12, int minute = 0)
        {
            Stunde = stunde;
            Minute = minute;
        }

        public void Tick()
        {
            Minute += 1;
        }

        public static Uhr Spaeter(Uhr uhr1, Uhr uhr2) // sollte Static sein da nicht auf Instanz der Klasse aufgerufen werden kann/sinn macht
        {
            return uhr1.Stunde * 60 + uhr1.Minute > uhr2.Stunde * 60 + uhr2.Minute ? uhr1 : uhr2;
        }

        public string ToString()
        {
            return $"{Stunde}:{Minute}";
        }
    }
}
