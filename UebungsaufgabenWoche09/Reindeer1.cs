using System;
using System.Collections.Generic;
using System.Text;

namespace UebungsaufgabenWoche09
{
    class Reindeer
    {
        string Name { get; set; }
        int Age { get; set; }
        bool RedNose { get; set; }

        public Reindeer() { }

        public Reindeer(string name, int age, bool redNose)
        {
            Name = name;
            Age = age;
            RedNose = redNose;
        }

        public string PrettyPrint()
        {
            return Name + " ist " + Age + " und hat " + (RedNose ? "eine" : "keine") + " rote Nase.";
        }
    }
}
