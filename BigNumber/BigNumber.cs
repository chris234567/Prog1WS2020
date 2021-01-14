using System;
using System.IO;


namespace BigNumber
{
    class BigNumber
    {
        string number { get; set; }

        public BigNumber(string number = "0")
        {
            if (number == null)
                throw new ArgumentException();

            bool leadingZero = true;

            if(number == "0")
            {
                this.number = number;
            }
            else
            {
                for (int position = 0; position < number.Length; position++)
                {
                    if (number[position] == 0 && leadingZero == true) // no leading zero allowed
                        throw new ArgumentException();

                    if (Convert.ToInt32(number[position]) > 0)
                    {
                        leadingZero = false;
                    }
                }
            }
        }

        public BigNumber Add(BigNumber n)
        {
            char[] myNumber = new char[number.Length];
            bool uebertrag = false;

            for (int i = 0; i < number.Length; i++)
            {
                int currInt = (int)number[i] + (int)n.number[i] - 48; // ASCII Adition

                if (uebertrag)
                    currInt = currInt + 49; // plus 1

                if (currInt > 57) // -> Uebertrag
                {
                    currInt = currInt - 57;
                    uebertrag = true;
                }

                myNumber[i] = (char)currInt;
            }

            return new BigNumber(myNumber.ToString());
        }

        public BigNumber Sub(BigNumber n)
        {
            if (Convert.ToInt32(n.number) >= Convert.ToInt32(number)) // greater or equal than. Aufgabenstellung etwas unklar. bei mir kann nicht null werden, da n.number kleiner sein muss als number
                throw new ArgumentException();

            char[] myNumber = new char[number.Length];
            int uebertrag = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int currInt = (int)number[i] - (int)n.number[i]; // ASCII Subtraction

                if (uebertrag < 0)
                    currInt = currInt - uebertrag;

                if (currInt < 48) // -> Uebertrag
                {
                    uebertrag = currInt;
                    currInt = 0;
                }

                myNumber[i] = (char)currInt; // no implicit conversion needed
            }

            return new BigNumber(myNumber.ToString());
        }

        public int CompareTo(BigNumber n)
        {
            for (int i = 0; i < number.Length; i++)
            {
                int a = Int32.Parse(number[i].ToString());
                int b = Int32.Parse(n.number[i].ToString());

                int r = a > b ? 0 : a < b ? 1 : 2;

                if (r < 2)
                    return r;
            }

            return 2;
        }

        public override string ToString()
        {
            return $"{Int32.Parse(number) / 1000}.{Int32.Parse(number) % 1000}";
        }

        public bool DivisorOf11()
        {
            int checksum = 0;

            for (int i = 0; i < this.number.Length; i++)
                checksum += i % 2 == 1 ? Int32.Parse(number[i].ToString()) : (-1) * Int32.Parse(number[i].ToString());

            return checksum % 11 == 0 ? true : false;
        }

        public int[] Histogram()
        {
            var nums = new int[10];

            for (int i = 0; i < number.Length; i++)
            {
                nums[Int32.Parse(number[i].ToString())]++;
            }
        }

        public static void ReadFile(string path, out int greatestNum, out int sum, out int elevens)
        {
            var myReader = new StreamReader(path);

            var myLine = myReader.ReadLine();
            greatestNum = "0";

            while (myLine != null)
            {
                if (CompareTo)
            }

            myReader.Close();
        }
    }
}
