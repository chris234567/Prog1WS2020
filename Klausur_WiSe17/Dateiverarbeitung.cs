using System;
using System.IO;

namespace Klausur_WiSe17_18
{
    class Dateiverarbeitung
    {
        public static void Rechnung(string[] bestellung)
        {
            var meals = new int[13];
             
            for (int i = 0; i < bestellung.Length; i++)
            {
                switch (bestellung[i])
                {
                    case "S1":
                        meals[0]++;
                        break;
                    case "S2":
                        meals[1]++;
                        break;
                    case "V1":
                        meals[2]++;
                        break;
                    case "V2":
                        meals[3]++;
                        break;
                    case "V3":
                        meals[4]++;
                        break;
                    case "H1":
                        meals[5]++;
                        break;
                    case "H2":
                        meals[6]++;
                        break;
                    case "H3":
                        meals[7]++;
                        break;
                    case "H4":
                        meals[8]++;
                        break;
                    case "H5":
                        meals[9]++;
                        break;
                    case "H6":
                        meals[10]++;
                        break;
                    case "H7":
                        meals[11]++;
                        break;
                    case "H8":
                        meals[12]++;
                        break;
                }
            }

            var myReader = new StreamReader(@"irgenteinpath");

            var line = myReader.ReadLine();

            while (line != null)
            {
                foreach (var meal in meals)
                {
                    var tempArray = line.Split(';');

                    switch (tempArray[0])
                    {
                        case "S1":
                            Console.WriteLine($"{meals[0]}x {tempArray[1]}: {tempArray[2]}");
                            break;
                        case "S2":
                            Console.WriteLine($"{meals[1]}x {tempArray[1]}: {tempArray[2]}");
                            break;
                        case "V1":
                            Console.WriteLine($"{meals[2]}x {tempArray[1]}: {tempArray[2]}");
                            break;
                        case "V2":
                            Console.WriteLine($"{meals[3]}x {tempArray[1]}: {tempArray[2]}");
                            break;
                        case "V3":
                            Console.WriteLine($"{meals[4]}x {tempArray[1]}: {tempArray[2]}");
                            break;
                        case "H1":
                            Console.WriteLine($"{meals[5]}x {tempArray[1]}: {tempArray[2]}");
                            break;
                        case "H2":
                            Console.WriteLine($"{meals[6]}x {tempArray[1]}: {tempArray[2]}");
                            break;
                        case "H3":
                            Console.WriteLine($"{meals[7]}x {tempArray[1]}: {tempArray[2]}");
                            break;
                        case "H4":
                            Console.WriteLine($"{meals[8]}x {tempArray[1]}: {tempArray[2]}");
                            break;
                        case "H5":
                            Console.WriteLine($"{meals[9]}x {tempArray[1]}: {tempArray[2]}");
                            break;
                        case "H6":
                            Console.WriteLine($"{meals[10]}x {tempArray[1]}: {tempArray[2]}");
                            break;
                        case "H7":
                            Console.WriteLine($"{meals[11]}x {tempArray[1]}: {tempArray[2]}");
                            break;
                        case "H8":
                            Console.WriteLine($"{meals[12]}x {tempArray[1]}: {tempArray[2]}");
                            break;
                    }
                }
            }

            myReader.Close();
        }
    }
}
