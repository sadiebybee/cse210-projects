public class RiddlePuzzle : Puzzle
{
    private static int riddleIndex = 0;

    private List<(string question, string answer)> riddles = new List<(string, string)>
    {
        ("What has keys but can't open locks?", "keyboard"),
        ("What has hands but can't clap?", "clock")
    };

    public RiddlePuzzle()
    {
        if (riddleIndex >= riddles.Count)
            riddleIndex = 0;

        var current = riddles[riddleIndex];
        Question = current.question;
        Answer = current.answer;

        riddleIndex++;
    }

    public override void Ask(Player player)
    {
        Console.WriteLine("An echoing voice speaks from the shadows:");
        Console.WriteLine("\"" + Question + "\"");
        Console.Write("> ");
        string input = Console.ReadLine();

        if (input == Answer)
            Console.WriteLine("Correct!\n");
        else
        {
            Console.WriteLine($"Incorrect. The correct answer was: {Answer}");
            player.TakeDamage(10);
            Console.WriteLine($"You lost 10 HP. Current Health: {player.GetHealthDisplay()}\n");
        }
    }
}
