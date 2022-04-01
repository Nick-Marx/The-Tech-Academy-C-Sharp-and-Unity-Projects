using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass mathClass = new MathClass();

            Console.WriteLine("Pick a number: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick another number or press 'Enter' if you don't want another number: ");
            int choice2;
            try
            {
                choice2 = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex)
            {
                choice2 = 1;
            }

            Console.WriteLine("\n" + mathClass.SomeMath(choice,choice2));
            Console.ReadLine();
        }
    }
}
