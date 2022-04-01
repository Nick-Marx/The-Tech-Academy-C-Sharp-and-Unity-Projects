using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            Console.WriteLine("What day of the week is it?");

            Week day = new Week();

            try
            {
                day = (Week)Enum.Parse(typeof(Week), textInfo.ToTitleCase(Console.ReadLine()));
                Console.WriteLine("You said today is {0}.", day);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            
            Console.ReadLine();
        }

        public enum Week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
