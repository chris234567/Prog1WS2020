using System;
using System.IO;

namespace Aufgabe2
{
    class Program
    {
        static void Main(string[] args)
        {
            var logLines = File.ReadAllLines(@"C:\Users\Chris\source\Prog12020\ProbeKlausur18_12_20\logfile.txt");

            // ( a ) 1

            var pid968Lines = new string[logLines.Length];

            for (int i = 0; i < logLines.Length; i++)
            {
                if (Contains(logLines[i], "pid 968")) // only recognizes pid 968 not [pid 968]??
                {
                    pid968Lines[i] = logLines[i];
                }
            }

            // ( a ) 1

            var myWriter = new StreamWriter(@"C:\Users\Chris\source\Prog12020\ProbeKlausur18_12_20\3594519_Aufgabe2\pid_968.txt", false);

            foreach (var logLine in pid968Lines)
            {
                if (logLine != null)
                    myWriter.WriteLine($"{logLine[12]}{logLine[13]}:{logLine[15]}{logLine[16]}:{logLine[18]}{logLine[19]}");
            }

            myWriter.Close();

            // ( b ) 

            int errorCount = 0;

            for (int i = 0; i < logLines.Length; i++)
            {
                if (Contains(logLines[i], "negotiation:error")) // only recognizes negotiation:error not error??
                {
                    errorCount++;
                }
            }

            Console.WriteLine($"There were {errorCount} errors");

            // ( c )

            var coreNoticeLines = new string[logLines.Length];

            for (int i = 0; i < logLines.Length; i++)
            {
                if (Contains(logLines[i], "core:notice"))
                {
                    coreNoticeLines[i] = logLines[i];
                }
            }

            string firstNotice = "";
            string lastNotice = "";

            for (int i = 0; i < coreNoticeLines.Length; i++) // goes through notices
            {
                if (coreNoticeLines[i] != null)
                {
                    firstNotice = coreNoticeLines[i];
                    break;
                }
            }

            for (int i = coreNoticeLines.Length - 1; i >= 0; i--) // goes through notices backwards
            {
                if (coreNoticeLines[i] != null)
                {
                    lastNotice = coreNoticeLines[i];
                    break;
                }
            }

            int firstHours = Convert.ToInt32(firstNotice[12] + "" + firstNotice[13]) * 60 * 60;
            int lastHours = Convert.ToInt32(lastNotice[12] + "" + lastNotice[13]) * 60 * 60;

            int firstMinutes = Convert.ToInt32(firstNotice[15] + "" + firstNotice[16]) * 60;
            int lastMinutes = Convert.ToInt32(lastNotice[15] + "" + lastNotice[16]) * 60;

            int firstSeconds = Convert.ToInt32(firstNotice[18] + "" + firstNotice[19]);
            int lastSeconds = Convert.ToInt32(lastNotice[18] + "" + lastNotice[19]);

            int firstTime = firstHours + firstMinutes + firstSeconds;
            int lastTime = lastHours + lastMinutes + lastSeconds;

            int timePassed = lastTime - firstTime;

            int timePassedHours = timePassed / (60 * 60);
            timePassed -= timePassedHours * (60 * 60);

            int timePassedMinutes = timePassed / 60;
            timePassed -= timePassedMinutes * 60;

            int timePassedSeconds = timePassed;

            string timePassedString = Convert.ToString(timePassedHours) + ":" + Convert.ToString(timePassedMinutes) + ":" + Convert.ToString(timePassedSeconds);

            Console.WriteLine("There has passed " + timePassedString + " between the fist and the last notice");
        }

        /// <summary>
        /// checks if a string contains another.
        /// </summary>
        /// <param name="line"></param>
        /// <param name="myString"></param>
        /// <returns>returns a true if thats the case.</returns>
        static bool Contains(string line, string myString)
        {
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == myString[0])
                {
                    for (int r = 1; r < myString.Length; r++)
                    {
                        if (line[i + r] != myString[r])
                            return false;
                    }

                    return true;
                }
            }

            return false;
        }

        // recursive approaches - no time for debugging

        //static bool Contains(string line, string myString, int i1 = 0, int position = 0)
        //{
        //    for (int i = i1; i < line.Length; i++)
        //    {
        //        if (position == myString.Length) // finished
        //            return true;

        //        if (line[i] == myString[position])
        //        {
        //            Console.WriteLine(i);
        //            Console.WriteLine(position);
        //            Contains(line, myString, i + 1, position + 1); // check next position
        //        }
        //    }

        //    return false;
        //}

        //static string[] GetLogLines(string[] myArray, string myString)
        //{
        //    string[] logLines = new string[myArray.Length];
        //    for (int r = 0; r < logLines.Length; r++)
        //    {
        //        int i = 0;

        //        if (CheckChars(myArray[r], myString, i))
        //            logLines[r] += myArray[r];
        //    }

        //    return logLines;
        //}

        //static bool CheckChars(string line , string myString, int position)
        //{
        //    if (position == myString.Length)
        //        return true;

        //    if (line[position] == myString[position])
        //        CheckChars(line, myString, position + 1);

        //    return false;
        //}
    }
}
