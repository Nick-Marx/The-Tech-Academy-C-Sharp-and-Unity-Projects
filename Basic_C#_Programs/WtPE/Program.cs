using System;

namespace WtPE
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n\nWhat is the package weight?");
            float weight = float.Parse(Console.ReadLine());

            if (weight > 50) {
                Console.WriteLine("\nPackage too heavy to be shipped via Package Express. Have a good day.");
                Console.Read();
                Environment.Exit(0);
            }

            Console.WriteLine("\nWhat is the package width?");
            float width = float.Parse(Console.ReadLine());

            Console.WriteLine("\nWhat is the package height?");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("\nWhat is the package length?");
            float length = float.Parse(Console.ReadLine());

            if ((width + height + length) > 50)
            {
                Console.WriteLine("\nPackage too big to be shipped via Package Express.");
                Console.Read();
                Environment.Exit(0);
            }

            float quote = (weight * width * height * length) / 100;

            Console.WriteLine("\nYour estimated total for shipping this package is: $" + quote + "\nThank you!");
            Console.Read();

        }
    }
}
