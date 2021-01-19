using System;

namespace _3594519_Aufgabe3
{
    class Fahrzeug
    {
        private int nr;
        private string modell;
        private double verbrauch;
        private FahrzeugTyp typ;
        private static int numberOfInstances = 0; 

        public string Modell
        {
            get
            {
                return modell;
            }
            set
            {
                modell = value.Length >= 5 ? value : throw new ArgumentException("Kein gueltiges Modell!"); // beides mal minimal 5 zeichen -- druckfehler in der angabe
            }
        }

        public double Verbrauch
        {
            get
            {
                return verbrauch;
            }
            // kein setter da read-only
        }

        public FahrzeugTyp Typ
        {
            get
            {
                return typ;
            }
            // kein setter da read-only
        }

        public Fahrzeug(string modell, double verbrauch, FahrzeugTyp typ = FahrzeugTyp.Kompakt)
        {
            // pruefung koennte man auch via property loesen - waere meiner meinung nach schoener
            this.modell = modell.Length >= 5 ? modell : throw new ArgumentException("Kein gueltiges Modell!"); // beides mal minimal 5 zeichen -- druckfehler in der angabe
            this.verbrauch = verbrauch < 15.0 ? verbrauch : throw new ArgumentException("Kein gueltiger Verbrauch!");
            this.typ = typ;
            nr = numberOfInstances + 1;
            numberOfInstances++;
        }

        public override string ToString()
        {
            return $"{nr}. {Typ} {Modell} ({Verbrauch}l/100km)";
        }
    }
}
