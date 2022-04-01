using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class MathClass
    {
        public int SomeMath(int x)
        {
            return ++x;
        }

        public int SomeMath(decimal y)
        {
            return Convert.ToInt32(y) * 2;
        }

        public int SomeMath(string z)
        {
            return Convert.ToInt32(z) - 4;
        }
    }
}
