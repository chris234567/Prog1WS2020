using System;
using System.Collections.Generic;
using System.Text;

namespace Klausur_WiSe15
{
    public enum MTyp
    {
        Angestellter,
        Gruppenleiter,
        Abteilungsleiter,
    }

    class Person
    {
        string name;
        double gehalt;
        MTyp mtyp;
        int personalnummer = 0;

        public int NaechstPersNr
        {
            get
            {
                return personalnummer + 1;
            }
            set
            {
                personalnummer = value >= NaechstPersNr ? value : throw new ArgumentOutOfRangeException();
            }
        }

        public Person(string name, double gehalt, MTyp mtyp, int personalnummer = -1)
        {
            this.name = name;
            this.gehalt = gehalt;
            this.mtyp = mtyp;
            this.personalnummer = personalnummer != -1 ? personalnummer : NaechstPersNr;
        }

        public static double Gehaltvolumen(Person[] personen, MTyp mtyp)
        {
            double sum = 0;

            for (int i = 0; i < personen.Length; i++)
                if (personen[i].mtyp == mtyp)
                    sum += personen[i].gehalt;

            return sum;
        }
    }
}
