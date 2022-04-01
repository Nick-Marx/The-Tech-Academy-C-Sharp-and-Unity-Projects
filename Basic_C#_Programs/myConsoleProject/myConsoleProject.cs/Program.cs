using System;
class Program{
    static void Main(){
        Console.WriteLine("The Tech Academy. \nStudent Daily Report. \nWhat is your name?");
        string name = Console.ReadLine();

        Console.WriteLine("\nWhat course are you on?");
        string courseTitle = Console.ReadLine();

        Console.WriteLine("\nWhat page number?");
        int pageNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDo you need help with anything? Please answer \"true\" or \"false.\"");
        bool needHelp = bool.Parse(Console.ReadLine());

        Console.WriteLine("\nWere there any positive experiences you’d like to share? Please give specifics.");
        string posExperiences = Console.ReadLine();

        Console.WriteLine("\nIs there any other feedback you’d like to provide? Please be specific.");
        string feedback = Console.ReadLine();

        Console.WriteLine("\nHow many hours did you study today?");
        int studyHours = int.Parse(Console.ReadLine());

        Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        Console.Read();
    }
}
