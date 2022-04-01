using System;
using System.Collections.Generic;

namespace fun_with_arrays
{
    class Program
    {
        static byte UserChoice()
        {
            byte choice = 0;
            Console.WriteLine("\nPlease pick an index number between 0 - 2 : ");
            try
            {
                choice = byte.Parse(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                choice = 3;
            }

            while (choice > 2)
            {
                Console.WriteLine("\nInvalid choice. Please pick an index number between 0 - 2 : ");
                try
                {
                    choice = byte.Parse(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    choice = 3;
                }
            }
            return choice;
        }
        static void Main()
        {
            string[] str = {"Help! Help! I'm being repressed!","She turned me into a newt!","Ni!"};

            int[] nums = {5,6,7};

            List<string> lyst = new List<string>{"Our king? Well, I didn't vote for you.","Now go away or I will taunt you a second time.","What is the air speed velocity of an unladen swallow?"};

            Console.WriteLine(str[UserChoice()]);
            Console.Read();

            Console.WriteLine(nums[UserChoice()]);
            Console.Read();

            Console.WriteLine(lyst[UserChoice()]);
            Console.Read();


        }
    }
}
