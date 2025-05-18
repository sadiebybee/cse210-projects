using System;
using JournalProject;

// For the stretch challenge I added an extra question at the 
// end of the entry that asks the user for their current mood.
// Their mood, along with the rest of the entry will be saved
// to the file.

class Program
{
    static void Main(string[] args)
    {
        //Creates a new instance of Journal
        Journal journal = new Journal();

        //Welcome banner
        Console.WriteLine("Welcome to Your Daily Journal!");

        bool running = true;
        while (running)
        {
            Console.WriteLine("Journal Menu: ");
            Console.WriteLine("1. New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Quit");
            Console.WriteLine();


            Console.Write("Please pick an option (1-5) ");
            string choice = Console.ReadLine();
            Console.WriteLine();


            switch (choice)
            {
                case "1":
                    journal.AddEntry();
                    Console.WriteLine();
                    break;

                case "2":
                    journal.DisplayEntries();
                    Console.WriteLine();
                    break;

                case "3":
                    journal.SaveToFile();
                    Console.WriteLine();
                    break;

                case "4":
                    journal.LoadFromFile();
                    Console.WriteLine();

                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Goodbye, see you next time!");
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Invalid, Please enter a number 1-5.");
                    Console.WriteLine();
                    break;
            }
        }
    }
}