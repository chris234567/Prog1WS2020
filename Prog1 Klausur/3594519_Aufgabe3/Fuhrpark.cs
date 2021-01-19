using System;

namespace _3594519_Aufgabe3
{
    class Fuhrpark
    {
        private Fahrzeug[] fahrzeuge;

        public Fuhrpark(params Fahrzeug[] fahrzeuge)
        {
            this.fahrzeuge = fahrzeuge;
        }

        public Fahrzeug Sparsamstes()
        {
            var sparsamstes = new Fahrzeug("irgenteinModell", 14.9);

            for (int i = 0; i < fahrzeuge.Length; i++)
            {
                sparsamstes = fahrzeuge[i].Verbrauch < sparsamstes.Verbrauch ? fahrzeuge[i] : sparsamstes;
            }

            return sparsamstes;
        }
    }
}
