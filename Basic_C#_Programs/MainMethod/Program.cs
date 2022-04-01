using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass mathclass = new MathClass();

            Console.WriteLine(mathclass.SomeMath(7));

            Console.WriteLine(mathclass.SomeMath(Convert.ToDecimal(12.3)));

            Console.WriteLine(mathclass.SomeMath(Convert.ToString(9)));

            Console.ReadLine();
        }
    }
}
