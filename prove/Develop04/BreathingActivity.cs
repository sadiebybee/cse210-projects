public class BreathingActivity : Activity
{
    private int _breathIn;
    private int _breathOut;

    public BreathingActivity(string name, string description, int duration, int breathIn, int breathOut)
        : base(name, description, duration)
    {
        _breathIn = breathIn;
        _breathOut = breathOut;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            PauseWithCountdown(_breathIn);

            Console.Write("Now breathe out... ");
            PauseWithCountdown(_breathOut);

            Console.WriteLine();
        }

        DisplayEndingMessage();
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

