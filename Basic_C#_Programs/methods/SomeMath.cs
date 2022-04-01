using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    public class SomeMath
    {
        public int AddOne(int x)
        {
            return ++x;
        }

        public int MinusOne(int y)
        {
            return --y;
        }

        public int TimesTwo(int z)
        {
            return z*2;
        }
    }
}
