using System;

namespace Praktikum8
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }
        static void Test()
        {
            Child k = new Child("Aris", Behavior.MostlyKind);
            k.AddWish("Sandspielzeug");
            k.AddWish("Bausteine");
            k.AddWish("Puppen");
            Console.WriteLine(k.AsString());

            ChildList liste = new ChildList(10);
            liste.AddChild(k);

            liste.AddChild(new Child("Anton", Behavior.AlwaysKind,
                new string[] { "Spielzeugauto", "Bausteine" }));
            liste.AddChild(new Child("Emma", Behavior.Naughty,
                new string[] { "Spielekonsole" }));
            liste.AddChild(new Child("Mehmet", Behavior.OftenKind,
                new string[] { "Bausteine", "Spielesammlung", "Sandspielzeug", "Computer" }));
            liste.AddChild(new Child("Esra", Behavior.MostlyKind,
                new string[] { "Handy", "Kinogutschein" }));
            liste.AddChild(new Child("Anna", Behavior.OftenKind,
                new string[] { "Musikstream", "Chemiebaukasten" }));
            liste.AddChild(new Child("Azra", Behavior.MostlyKind,
                new string[] { "Elektronik-Baukasten", "Computer", "Handy" }));
            liste.AddChild(new Child("Hans", Behavior.Naughty,
                new string[] { "Spielzeugautos", "Kinogutscheine" }));
            liste.AddChild(new Child("Egon", Behavior.AlwaysKind,
                new string[] { "Puppen", "Spielekonsole" }));
            liste.AddChild(new Child("Marie", Behavior.MostlyKind,
                new string[] { "Handy", "Spielekonsole" }));

            Console.WriteLine($"Anzahl lieber Kinder: {liste.NumberOfKindChildren}");
            Console.WriteLine("So oft wünschen sich Kinder ...");
            foreach (string wish in new string[] { "Handy", "Computer", "Spielekonsole", "Bausteine", "Puppen" })
                Console.WriteLine($"... {wish}:   {liste.CountChildrenWithWish(wish)}");
        }
    }
}

