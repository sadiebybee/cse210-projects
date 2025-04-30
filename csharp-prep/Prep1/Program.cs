using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep1 World!");

        // Prompt the user for their first name. Then, prompt them for their last name.
        Console.Write("What is your first name? ");
        string fname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lname = Console.ReadLine();

        // Display the text back all on one line saying
        Console.WriteLine($"Your name is {lname}, {fname}, {lname}");
    }
}
