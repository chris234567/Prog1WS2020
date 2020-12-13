using System;
using System.Collections.Generic;
using System.Text;

namespace Praktikum8
{
    enum Behavior
    {
        AlwaysKind,
        MostlyKind,
        OftenKind,
        Naughty
    }
    class Child
    {
        string name;
        public string[] wishes = new string[3]; // wishlist of child
        public bool wishless = true;

        public Behavior Behavior
        {
            get; private set;
        }

        public bool WasKind
        {
            get
            {
                return this.Behavior != Behavior.Naughty;
            }
        }

        public Child(string name, Behavior behavior, string[] wishes = null)
        {
            this.name = name;
            this.Behavior = behavior;

            if (wishes != null)
                foreach (var wish in wishes)
                    AddWish(wish);
        }

        public void AddWish(string wish) // adds wish to string[] wishes ( if not full )
        {
            for (int i = 0; i < wishes.Length; i++)
            {
                if (wishes[i] == null)
                {
                    wishes[i] = wish;
                    wishless = false;
                    return;
                }
            }
        }

        public bool HasWish(string wish) // checks if child has a certain wish
        {
            foreach (var item in wishes)
            {
                if (item == wish)
                    return true;
            }
            return false;
        }

        public void IsImproving()
        {
            int index = Array.IndexOf(Enum.GetValues(Behavior.GetType()), Behavior);

            if (index != Enum.GetNames(typeof(Behavior)).Length) // if index is last of enum, behavior cannot improve
                this.Behavior = (Behavior)Enum.GetValues(Behavior.GetType()).GetValue(index + 1); // behavior gets shifted by one
        }

        public (string, string) AsString() // returns name and behavior of child as string
        {
            return (name.ToString(), Behavior.ToString());
        }
    }
}
