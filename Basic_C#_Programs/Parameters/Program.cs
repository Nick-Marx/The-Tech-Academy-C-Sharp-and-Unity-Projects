using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> HenchmanOne = new Employee<string>();
            HenchmanOne.things = new List<string>() { "red","blue","yellow"};

            Employee<int> HenchmanTwo = new Employee<int>();
            HenchmanTwo.things = new List<int>() { 7,8,9 };

            foreach (string str in HenchmanOne.things)
            {
                Console.WriteLine(str);
            }
            foreach (int e in HenchmanTwo.things)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
