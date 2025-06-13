using System;

// For the stretch challenge, I added a count system that keeps track of 
// how many times the user does an activity in one session. I then added a
// summary that is displayed when the user decides to quit the program. The 
// summary shows the total amount of times the the user did an activity in 
// the session.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Mindfullness Activity!");
        Console.WriteLine();

        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

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
                    breathingCount++;
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
                    reflectingCount++;
                    ReflectingActivity reflect = new ReflectingActivity(
                    "Reflection",
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                    0 // Duration is set in DisplayStartingMessage
                    );
                    reflect.Run();
                    break;

                case "3":
                    listingCount++;
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
                    Console.WriteLine("\nSession Summary:");
                    Console.WriteLine($"Breathing Activities completed: {breathingCount}");
                    Console.WriteLine($"Reflecting Activities completed: {reflectingCount}");
                    Console.WriteLine($"Listing Activities completed: {listingCount}");
                    int totalActivities = breathingCount + reflectingCount + listingCount;
                    Console.WriteLine($"Total Activities: {totalActivities}");
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