using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //PART ONE
            string[] str = {"blue-","red-","yellow-"};

            Console.WriteLine("Please type something you would like added to the end of each string in the array of colors.");
            string userInput = Console.ReadLine();

            for (int i = 0; i< str.Length; i++)
            {
                str.SetValue(str[i] + userInput, i);
            }

            foreach (string i in str)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            //PART TWO
            for (int i = 0;i<str.Length;i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            //PART THREE
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(i + 3);
            }
            Console.ReadLine();

            for (int i = 0; i <= str.Length; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            //PART FOUR
            List<string> lyst = new List<string>() {"purple","orange","green"};

            Console.WriteLine("Please type in a color to search for in the list. Choices are: 'purple', 'orange', 'green.'");
            string choosey = Console.ReadLine();
            
            foreach (string i in lyst) 
            {
                if (choosey == i)
                {
                    Console.WriteLine("That item is at index " + lyst.FindIndex(0,3, i.StartsWith));
                    break;
                }
                else
                {
                    Console.WriteLine("That item is not at index " + lyst.FindIndex(0, 3, i.StartsWith));
                }
            }
            Console.ReadLine();

            //PART FIVE
            List<string> lyst2 = new List<string>() { "apple", "apple", "banana" };

            Console.WriteLine("Please type in a fruit to search for in the list. Choices are: 'apple' and 'banana.'");
            string choosey2 = Console.ReadLine();

            for (int i = 0; i<3;i++)
            {
                if (choosey2 == lyst2[i])
                {
                    Console.WriteLine("That item is at index " + i);
                }
                else
                {
                    Console.WriteLine("That item is not at index " + i);
                }
            }
            Console.ReadLine();

            //PART SIX
            List<string> lyst3 = new List<string>() { "car", "car", "truck" };
            List<string> lyst4 = new List<string>();

            foreach (string i in lyst3)
            {
                if (lyst4.Contains(i))
                {
                    Console.WriteLine(i +" is a duplicate.");
                    continue;
                }
                Console.WriteLine(i);
                lyst4.Add(i);
            }
            Console.ReadLine();
        }
    }
}
