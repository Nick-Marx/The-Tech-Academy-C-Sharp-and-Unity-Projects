using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee HenchmanOne = new Employee() { Id = 1 };
            Employee HenchmanTwo = new Employee() { Id = 2 };

            Console.WriteLine(HenchmanOne == HenchmanTwo);
            Console.ReadLine();
        }
    }
}
