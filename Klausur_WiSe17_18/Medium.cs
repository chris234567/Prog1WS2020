using System;

namespace Klausur_WiSe17_18
{
    enum Medientyp
    {
        Foto,
        DVD,
        mp4,
        Audio,
    }
    class Medium
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        int serNr;
        Medientyp typ;
        static int numberOfInstances = 0;

        public Medium(string name, Medientyp typ = Medientyp.Foto)
        {
            this.name = name;
            this.typ = typ;
            numberOfInstances++;
            serNr = numberOfInstances;
        }

        public static int[] Statistik (Medium[] array)
        {
            var intArray = new int[4];

            for (int i = 0; i < array.Length; i++)
            {
                int value = (int)array[i].typ;
                intArray[value]++;
            }

            return intArray;
        }

        public static Medium Suche(Medium[] array, string name)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].name == name)
                    return array[i];
            }

            return null;
        }
    }
}
