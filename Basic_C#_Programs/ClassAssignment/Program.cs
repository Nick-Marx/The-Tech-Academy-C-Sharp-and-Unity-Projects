using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Pick a number: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            int y;
            MathClass.SomeMath(choice,out y);
            Console.WriteLine(y);
            MathClass.SomeMath(22);

            Console.ReadLine();
        }
    }
}
