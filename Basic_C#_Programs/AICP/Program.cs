using System;

namespace AICP
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program\n\nPerson 1:\nHourly Rate: ");
            float personOneHourlyRate = float.Parse(Console.ReadLine());

            Console.WriteLine("\nHours worked per week: ");
            float personOneHoursWorkedPerWeek = float.Parse(Console.ReadLine());

            Console.WriteLine("\nPerson 2:\nHourly Rate: ");
            float personTwoHourlyRate = float.Parse(Console.ReadLine());

            Console.WriteLine("\nHours worked per week: ");
            float personTwoHoursWorkedPerWeek = float.Parse(Console.ReadLine());

            float p1AS = (personOneHourlyRate * personOneHoursWorkedPerWeek * 52);
            float p2AS = (personTwoHourlyRate * personTwoHoursWorkedPerWeek * 52);

            Console.WriteLine("\nAnnual salary of Person 1: " + p1AS);

            Console.WriteLine("\nAnnual salary of Person 2: " + p2AS);

            Console.WriteLine("\nDoes Person 1 make more money than Person 2?\n" + (p1AS > p2AS));

            Console.Read();

        }
    }
}
