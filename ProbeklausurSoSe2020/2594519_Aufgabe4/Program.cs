using System;
using System.IO;

namespace _2594519_Aufgabe4
{
    class Program
    {
        static void Main(string[] args)
        {
            // read

            var myReader = new StreamReader(@"C:\Users\Chris\source\Prog12020\ProbeklausurSoSe2020\2594519_Aufgabe4\logfile.txt");
            var port50826 = new string[myReader.ReadToEnd().Split("\n").Length];

            myReader = new StreamReader(@"C:\Users\Chris\source\Prog12020\ProbeklausurSoSe2020\2594519_Aufgabe4\logfile.txt");
            var myLine = myReader.ReadLine();
            var counter = 0;
            var error = 0;

            string startTime = null;
            string endTime = null;

            while(myLine != null)
            {
                if (myLine.Contains("192.168.169.208:50826"))
                    port50826[counter] = myLine;

                if (myLine.Contains("error"))
                    error++;

                if (myLine.Contains("[core:notice]"))
                {
                    startTime = startTime == null ? myLine.Split(' ')[3].Substring(0, 8) : startTime; // a bit crooked but one if less
                    endTime = myLine.Split(' ')[3].Substring(0, 8);
                }

                myLine = myReader.ReadLine();
                counter++;
            }

            myReader.Close();

            // write

            var myWriter = new StreamWriter(@"C:\Users\Chris\source\Prog12020\ProbeklausurSoSe2020\2594519_Aufgabe4\port_50826.txt", false); // creates new file if it doesnt exist

            foreach (var line in port50826)
            {
                if (line != null)
                    myWriter.WriteLine(line);
            }

            myWriter.Close();

            Console.WriteLine("Errorcount: " + error);

            int sTSec = Int32.Parse(startTime.Substring(0, 2)) * 60 * 60 + Int32.Parse(startTime.Substring(3, 2)) * 60 + Int32.Parse(startTime.Substring(6, 2));
            int eTSec = Int32.Parse(endTime.Substring(0, 2)) * 60 * 60 + Int32.Parse(endTime.Substring(3, 2)) * 60 + Int32.Parse(endTime.Substring(6, 2));

            int deltaTime = eTSec - sTSec;

            Console.WriteLine("Time passed in min: " + (deltaTime / 60));

        }
    }
}
