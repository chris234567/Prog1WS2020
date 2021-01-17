using System;
using System.Collections.Generic;
using System.Text;

namespace Klausur_SoSe17
{
    public enum Sportarten
    {
        Fuss,
        Hand,
        Golf,
    }

    class Ball
    {
        private double durchmesser;
        private Sportarten sportart;
        private int id;
        private static int numberOfInstances = 0;

        public double Durchmesser
        {
            get
            {
                return durchmesser;
            }
            set
            {
                durchmesser = value > 0 ? value : throw new ArgumentOutOfRangeException();
            }
        }

        public Ball(double durchmesser, Sportarten sportart = Sportarten.Fuss)
        {
            this.durchmesser = durchmesser;
            this.sportart = sportart;
            id = numberOfInstances;
            numberOfInstances++;
        }

        public bool IstKleiner(Ball ball)
        {
            return this.Durchmesser < ball.Durchmesser;
        }
    }
}
