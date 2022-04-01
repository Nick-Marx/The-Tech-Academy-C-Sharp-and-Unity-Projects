using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lyst = new List<int> {10,20,30};
            Console.WriteLine("Pick a number: ");
            try
            {
                int userNumber = int.Parse(Console.ReadLine());

                foreach (int i in lyst)
                {
                    Console.WriteLine(i / userNumber);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error. User input wrong format. Please pick a non-zero integer.");
            }
            Console.WriteLine("Try/Catch Complete");
            Console.ReadLine();
        }
    }
}
