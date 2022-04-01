using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public static class MathClass
    {
        public static void SomeMath(int x, out int y)
        {
            y = x / 2;
        }

        public static void SomeMath(byte x)
        {
            Console.WriteLine(x);
        }
    }
}
