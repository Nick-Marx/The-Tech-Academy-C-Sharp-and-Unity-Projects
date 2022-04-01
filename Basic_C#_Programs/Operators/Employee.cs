using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Employee
    {
        public int Id { get; set; }

        public static bool operator ==(Employee x, Employee y)
        {
            return x.Id == y.Id;
        }
        public static bool operator !=(Employee x, Employee y)
        {
            return x.Id != y.Id;
        }
    }
}
