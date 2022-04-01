using System;

namespace CIAP
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Basic Approval Program for Car Insurance\n\nWhat is your age? ");
            byte age = byte.Parse(Console.ReadLine());

            Console.WriteLine("\nHave you ever had a DUI? Please type \"true\" or \"false.\" ");
            bool DUI = bool.Parse(Console.ReadLine());

            Console.WriteLine("\nHow many speeding tickets do you have? ");
            byte speedingTickets = byte.Parse(Console.ReadLine());

            Console.WriteLine("\nQualified?\n" + (age > 14 && !DUI && speedingTickets < 4));

            Console.Read();
        }
    }
}
