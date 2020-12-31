using System;
using System.Collections.Generic;
using System.Text;

namespace _2594519_Aufgabe3
{
    class Lautsprecher
    {
        // a)
        public string Id { get; private set; }

        public string Bennenung { get; private set; }

        public Kanal Kanal { get; private set; }

        public double lautstaerke;

        // b)
        public double Lautstaerke 
        {
            get { return lautstaerke; }

            set
            {
                if (lautstaerke - value <= 15 && lautstaerke - value >= -15) // Math.Abs would be more elegant
                {
                    lautstaerke = value;
                }
            } 
        }

        // d)
        public Lautsprecher(string Id, string Bennenung, Kanal Kanal, double Lautstaerke)
        {
            this.Id = Id;
            this.Bennenung = Bennenung;
            this.Kanal = Kanal;
            this.lautstaerke = Lautstaerke;
        }

        // c)
        public string Einstellung
        {
            get { return $"{lautstaerke} phon {Kanal}"; }
        }

        public string AlsString()
        {
            return $"{Id}, {Bennenung}: {lautstaerke} phon {Kanal}";
        }

        public static Lautsprecher Simulation(string Id, string Bennenung)
        {
            var newKanal = (Kanal)new Random().Next(1, 4);
            double newLautstaerke = new Random().NextDouble() * 90 + 10;

            return new Lautsprecher(Id, Bennenung, newKanal, newLautstaerke);
        }
    }
}
