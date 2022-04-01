using System;
using System.Text;

namespace fun_with_strings
{
    class Program
    {
        static void Main()
        {
            string first = "My ";
            string second = "name ";
            string third = "is ";
            string fourth = "nick.";

            Console.WriteLine(first + second + third + fourth.ToUpper());

            StringBuilder sb = new StringBuilder();

            sb.Append("It's very good to meet you. ");
            sb.Append("I am practicing with strings in c#. ");
            sb.Append("This is an example of appending strings using StringBuilder.");

            Console.Write("\n" + sb);
            Console.Read();


        }
    }
}
