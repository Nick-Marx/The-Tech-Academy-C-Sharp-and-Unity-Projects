using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass MathClass = new MathClass();

            MathClass.SomeMath(2,3);
            MathClass.SomeMath(x: 4, y: 5);

            Console.ReadLine();
        }
    }
}
