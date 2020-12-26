using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace UebungsaufgabenWoche09
{
    class Sled
    {
        Reindeer[] reindeers = new Reindeer[9];

        public string Reindeers
        {
            get
            {
                string s = "";

                foreach (var reindeer in reindeers)
                {
                    s += "\n" + reindeer.PrettyPrint();
                }

                return s;
            }
        }

        public Sled(Reindeer[] reindeers)
        {
            this.reindeers = reindeers;
        }

        public Sled(Reindeer[] reindeers, int reindeerCount)
        {
            this.reindeers = new Reindeer[reindeerCount];
            this.reindeers = reindeers;
        }

        public static Sled ReindeerSquadronAssemble(string path)
        {
            var myReader = new StreamReader(path);

            var line = myReader.ReadLine(); // curr line
            int counter = 0; // line position

            var myReindeers = new Reindeer[File.ReadAllLines(path).Length];

            do
            {
                string[] cutLine = line.Split(',');

                myReindeers[counter] = new Reindeer(cutLine[0], Convert.ToInt32(cutLine[1]), cutLine[2] == "ja" ? true : false);

                counter++; // update line position
                line = myReader.ReadLine(); // update curr line

            } while (line != null);

            return new Sled(myReindeers, myReindeers.Length);
        }
    }
}
