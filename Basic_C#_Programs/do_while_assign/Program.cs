using System;

namespace do_while_assign
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess a number from 1 - 10");
            int guess = int.Parse(Console.ReadLine());

            while(guess != 10)
            {
                Console.WriteLine("\nIncorrect, please guess again.");
                guess = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nCorrect! Way to go!\n\nThis time you pick a number from 1 - 20 and I will try to guess it");
            Random rand = new Random();
            bool success = false;

            do
            {
                guess = rand.Next(1, 21);

                Console.WriteLine("\nIs the number: " + guess + " ?\nType 'true' or 'false': ");
                success = bool.Parse(Console.ReadLine());
            }
            while (!success);

            Console.WriteLine("\nThat was fun! Thanks for playing!");
            Console.Read();

        }
    }
}
