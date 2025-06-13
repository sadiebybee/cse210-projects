public class ListingActivity : Activity
{
    private List<string> _prompts;
    private Random _random;

    public ListingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _random = new Random();
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();

        string prompt = GetRandomPrompt();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("You may begin in:");
        PauseWithCountdown(5);  // Give the user a few seconds to prepare
        Console.WriteLine("Start listing. Press Enter after each item:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                Console.ReadLine();
                count++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {count} items.");
        PauseWithSpinner(3);
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    private void PauseWithCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}