using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Mindfullness Activity!");
        Console.WriteLine();

        bool running = true;
        while (running)
        {
            Console.WriteLine("Mindfulness Menu: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.WriteLine();
            Console.Write("Please pick an option ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity(
                    "Breathing",
                    "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",
                    0,  // Duration will be set in DisplayStartingMessage()
                    4,  // Time to breathe in
                    6   // Time to breathe out
                    );
                    breathing.Run();
                    break;

                case "2":
                    ReflectingActivity reflect = new ReflectingActivity(
                    "Reflection",
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                    0 // Duration is set in DisplayStartingMessage
                    );
                    reflect.Run();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity(
                    "Listing",
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                    0 // Duration is set in DisplayStartingMessage
                    );
                    listing.Run();
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("Goodbye, see you next time!");
                    Console.WriteLine();
                    break;
                
                default:
                    Console.WriteLine("Invalid, Please enter a number 1-4.");
                    Console.WriteLine();
                    break;
            }
        }
    }
}