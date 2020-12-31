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

        public static string Serialize(Child child)
        {
            var wishesString = "";
            var counter = 0;

            foreach (var wish in child.wishes)
            {
                if (wish != null)
                {
                    wishesString += wish;

                    Console.WriteLine(child.wishes.Length);
                    Console.WriteLine(child.name);

                    if (child.wishes.Length <= 1)
                        continue;

                    counter++;

                    if (counter < child.wishes.Length) // add comma only for median wishes
                        wishesString += ",";
                }
            }

            return $"{child.name},{child.Behavior}:{wishesString}"; // for use with Deserialize() non void
        }

        public static Child Deserialize(string childString)
        {
            var childProperties = childString.Split(',', ':');

            var name = childProperties[0];
            var behavior = childProperties[1];

            if (name == null)
                return null;

            if (behavior == null)
                return null;

            var newChild = new Child(name, (Behavior) Enum.Parse(typeof(Behavior), behavior, true));

            for (int i = 2; i < childProperties.Length; i++)
            {
                if (childProperties.Length <= i)
                    break;
                    
                newChild.AddWish(childProperties[i]);
            }

            return newChild;
        }
    }
}
