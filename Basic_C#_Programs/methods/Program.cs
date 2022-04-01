using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick an integer: ");
            int choice = int.Parse(Console.ReadLine());
            SomeMath SomeMath = new SomeMath();

            Console.WriteLine(SomeMath.AddOne(choice));
            Console.WriteLine(SomeMath.MinusOne(choice));
            Console.WriteLine(SomeMath.TimesTwo(choice));
            Console.ReadLine();
        }
    }
}
