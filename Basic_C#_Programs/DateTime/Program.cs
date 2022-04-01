using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            Console.WriteLine("\nPick a number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nIn {0} hours it will be {1}.", number, dt.AddHours(number));
            Console.ReadLine();
        }
    }
}
