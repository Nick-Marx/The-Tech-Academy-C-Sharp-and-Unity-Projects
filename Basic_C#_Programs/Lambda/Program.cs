using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EvilHenchmen = new List<Employee>();

            Employee henchmanOne = new Employee() {Id=1,firstName="Joe",lastName="Smith" };
            EvilHenchmen.Add(henchmanOne);

            Employee henchmanTwo = new Employee() { Id = 2, firstName = "Joe", lastName = "Samson" };
            EvilHenchmen.Add(henchmanTwo);

            Employee henchmanThree = new Employee() { Id = 3, firstName = "Bob", lastName = "Smith" };
            EvilHenchmen.Add(henchmanThree);

            Employee henchmanFour = new Employee() { Id = 4, firstName = "Dan", lastName = "Powers" };
            EvilHenchmen.Add(henchmanFour);

            Employee henchmanFive = new Employee() { Id = 5, firstName = "Levi", lastName = "Garcia" };
            EvilHenchmen.Add(henchmanFive);

            Employee henchmanSix = new Employee() { Id = 6, firstName = "Sam", lastName = "Byers" };
            EvilHenchmen.Add(henchmanSix);

            Employee henchmanSeven = new Employee() { Id = 7, firstName = "Josh", lastName = "Wens" };
            EvilHenchmen.Add(henchmanSeven);

            Employee henchmanEight = new Employee() { Id = 8, firstName = "Alex", lastName = "Holt" };
            EvilHenchmen.Add(henchmanEight);

            Employee henchmanNine = new Employee() { Id = 9, firstName = "Bill", lastName = "Morhead" };
            EvilHenchmen.Add(henchmanNine);

            Employee henchmanTen = new Employee() { Id = 10, firstName = "Tom", lastName = "Knot" };
            EvilHenchmen.Add(henchmanTen);

            List<Employee> NotAsEvilHenchmen = new List<Employee>();
            NotAsEvilHenchmen = EvilHenchmen.Where(x => x.firstName == "Joe").ToList();

            List<Employee> RookieHenchmen = new List<Employee>();
            RookieHenchmen = EvilHenchmen.Where(x => x.Id > 5).ToList();

            foreach (Employee emp in EvilHenchmen)
            {
                Console.WriteLine(emp.firstName);
            }
            Console.WriteLine();
            foreach (Employee emp in NotAsEvilHenchmen)
            {
                Console.WriteLine(emp.firstName + " " + emp.lastName);
            }
            Console.WriteLine();
            foreach (Employee emp in RookieHenchmen)
            {
                Console.WriteLine(emp.Id + " " + emp.lastName);
            }
            Console.ReadLine();
        }
    }
}
