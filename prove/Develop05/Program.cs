using System;

// For the Stretch Challenge, I added a delete goal option in the menu,
// I added an emoji on the EternalGoal that will show it is infinate goal,
// and I also added motiviational quotes for when you enter the program
// and when you complete a goal.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Eternal Quest Program!");
        Console.WriteLine();

        QuestManager questManager = new QuestManager();

        questManager.DisplayRandomQuote(); // Show motivational quote at startup

        bool running = true;
        while (running)
        {
            Console.WriteLine($"Current Score: {questManager.Score} points");
            Console.WriteLine();

            Console.WriteLine("Eternal Quest Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Delete Goal");
            Console.WriteLine("7. Quit");
            Console.WriteLine();

            Console.Write("Please pick an option: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    questManager.CreateGoal();
                    Console.WriteLine();
                    break;

                case "2":
                    questManager.ListGoals();
                    Console.WriteLine();
                    break;

                case "3":
                    questManager.SaveToFile();
                    Console.WriteLine();
                    break;

                case "4":
                    questManager.LoadFromFile();
                    Console.WriteLine();
                    break;

                case "5":
                    questManager.RecordEvent();
                    Console.WriteLine();
                    break;

                case "6":
                    questManager.DeleteGoal();
                    break;

                case "7":
                    running = false;
                    Console.WriteLine("Goodbye, see you next time!");
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Invalid, please enter a number 1-6.");
                    Console.WriteLine();
                    break;
            }
        }
    }
}
