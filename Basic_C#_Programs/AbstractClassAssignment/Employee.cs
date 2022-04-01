using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee:Person
    {
        public override void SayName()
        {
            Console.WriteLine("Person name: {0} {1}", firstName, lastName);
            Console.ReadLine();
        }
    }
}
