using System;
using System.Collections.Generic;
using System.Text;

namespace Klausur_WiSe_18_19
{
    public enum Status
    {
        Neu,
        Offen,
        Bearbeitet,
        Geschlossen,
    }
    class Bug
    {
        private int id;
        private string bez;
        private Status status;
        private static int numberOfInstances = 0;

        public bool Gefixt
        {
            get
            {
                return status == Status.Bearbeitet || status == Status.Geschlossen;
            }
        }

        public Bug(string bez, Status status = Status.Neu)
        {
            if (bez == null) // koennte man auch via property loesen
                throw new ArgumentException();

            this.id = numberOfInstances;
            numberOfInstances++;
            
            this.bez = bez;
            this.status = status;
        }

        public bool IstDuplikat(Bug b)
        {
            return bez == b.bez;
        }

        public static void DuplikateAusgeben(params Bug[] bugs)
        {
            for (int i = 0; i <= bugs.Length / 2; i++)
            {
                for (int r = i + 1; r < bugs.Length; r++)
                {
                    if (bugs[i].bez == bugs[r].bez) 
                        Console.WriteLine($"{bugs[i].id} = { bugs[r].id}");
                }
            }
        }

    }
}
