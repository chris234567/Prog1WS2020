using System;
using System.Collections.Generic;
using System.Text;

namespace ProbeKlausur_SoSe_18
{
    class Menge
    {
        private int[] elements;
        private int anzahl;

        int Size
        {
            get
            {
                return anzahl; // alternativ das array elements nach nicht 0 stellen durchsuchen und deren anzahl zurueckgeben
            }
        }

        public Menge(int i = 10)
        {
            elements = new int[i];
        }

        public bool IsElem(int i)
        {
            foreach (var num in elements)
            {
                if (num == i)
                    return true;
            }
            return false;
        }

        public void Add(int i)
        {
            if (elements.Length == 10)
                throw new OverflowException();

            if (!IsElem(i))
                for (int r = 0; r < elements.Length; r++)
                {
                    if (elements[r] == 0)
                    {
                        elements[r] = i;
                        anzahl++;
                        break;
                    }
                }
        }

        public static int Suche(Menge[] menge, int i)
        {
            try
            {
                for (int r = 0; r < menge.Length; r++)
                {

                    for (int l = 0; l < menge[r].elements.Length; l++)
                    {
                        if (menge[r].elements[l] == i)
                            return r;
                    }
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Please initialise Menge[] with Menge objects before calling this Method!");
            }
            return -1;
        }
    }
}
