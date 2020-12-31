using System;

namespace Prog1Uebung09122020
{
    class RGB
    {
        int red;
        int green;
        int blue;
        //static void Main(string[] args)
        //{
        //    //RGB Cyan = new RGB(0, 255, 255);
        //    //RGB Yellow = new RGB(255, 255, 0);
        //    //RGB Magenta = new RGB(255, 0, 255);

        //    //Cyan.Display();
        //    //Yellow.Display();
        //    //Magenta.Display();

        //    //RGB Color = new RGB();
        //    //Color.ChooseColor();
        //    //Color.Display();
        //}
        public RGB()
        {
            this.red = 0;
            this.green = 0;
            this.blue = 0;
        }
        public RGB(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }
        public void SetColor(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }
        public void Display()
        {
            if (ValidColor(red) && ValidColor(green) && ValidColor(blue))
                Console.WriteLine($"({red}, {green}, {blue})");
            else
                Console.WriteLine("Error!!!!!");
        }
        public bool ChooseColor()
        {
            Console.WriteLine("Please enter a red value: ");
            int red = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a green value: ");
            int green = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a blue value: ");
            int blue = Convert.ToInt32(Console.ReadLine());

            if (!ValidColor(red) && !ValidColor(green) && !ValidColor(blue))
                return false;
            SetColor(red, green, blue);
            return true;
        }
        public bool ValidColor(int color)
        {
            if (0 <= color && color <= 255)
                return true;
            return false;
        }
    }
}
