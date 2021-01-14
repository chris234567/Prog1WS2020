using System;
using System.Collections.Generic;
using System.Text;

namespace Klausur_WiSe19_20
{
    enum Orientierung
    {
        Hoch,
        Quer,
    }

    class Foto
    {
        public string Name { get; set; }
        double Blende;
        Orientierung Ori;
        int BildNr;
        static int VorherigeBildNummer;
        public int ImageNumber
        {
            get
            {
                return BildNr;
            }
        }
        public Foto(string name, double blende, Orientierung ori = Orientierung.Quer)
        {
            Name = name;
            Blende = blende;
            Ori = ori;
            BildNr = VorherigeBildNummer;
            VorherigeBildNummer++;
        }

        public int IndexOf(Foto[] fotos)
        {
            for(int i = 0; i < fotos.Length; i++)
            {
                if (fotos[i].BildNr == BildNr)
                    return i;
            }
            return -1;
        }

        public static Foto[] BlendenFilter(Foto[] fotos, double blendenGrenze)
        {
            int length = 0;

            for (int i = 0; i < fotos.Length; i++)
            {
                if (fotos[i].Blende <= blendenGrenze)
                    length++;
            }

            var filteredFotos = new Foto[length];
            int counter = 0;

            for (int i = 0; i < fotos.Length; i++)
            {
                if (fotos[i].Blende <= blendenGrenze)
                {
                    filteredFotos[counter] = fotos[i];
                    counter++;
                }
            }

            return filteredFotos;
        }

        public string ToString()
        {
            return $"{Name}, {Blende}, {Ori}, {BildNr}";
        }
    }
}
