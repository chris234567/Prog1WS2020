using System;

namespace UebungsaufgabenWoche07
{
    class Student
    {
        // string LastName { get; set; } // setter ausbauen ( in kurzschreibweise) ??

        string lastName;

        string LastName
        {
            get { return lastName; }
            set
            {
                if (value.Length > 2)
                    lastName = value;
                else
                    throw new Exception("Feld wurde nicht gesetzt, war nicht valide!");
            }
        }

        private string FirstName { get; set; }

        private int matrikelnummer;
        
        int Matrikelnummer
        {
            get { return matrikelnummer; }
            set 
            { 
                if (value > 99999 && value < 1000000)
                    matrikelnummer = value;
                else
                    throw new Exception("Feld wurde nicht gesetzt, war nicht valide!");
            }
        }

        private int ects;

        int Ects
        {
            get { return ects; }
            set 
            { 
                if (value > 29 && value < 121)
                    ects = value;
                else
                    throw new Exception("Feld wurde nicht gesetzt, war nicht valide!");
            }
        }

        public Student(string LastName, string FirstName, int Matrikelnummer, int Ects)
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.Matrikelnummer = Matrikelnummer;
            this.Ects = Ects;
        }

        public void Speak()
        {
            Console.WriteLine($"Hello, my name is {FirstName} {LastName}.");
            Console.WriteLine($"{Matrikelnummer} is my student ID and i currently have {Ects} ECTS.");
        }
    }
}
