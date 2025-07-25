public class WordScramblePuzzle : Puzzle
{
    private static int scrambleIndex = 0;

    private List<(string question, string answer)> scrambles = new List<(string, string)>
    {
        ("Unscramble this word: eporctmu", "computer"),
        ("Unscramble this word: atephlen", "elephant")
    };

    public WordScramblePuzzle()
    {
        if (scrambleIndex >= scrambles.Count)
            scrambleIndex = 0;

        var current = scrambles[scrambleIndex];
        Question = current.question;
        Answer = current.answer;

        scrambleIndex++;
    }

    public override void Ask(Player player)
    {
        Console.WriteLine("You find a scroll on the wall, the letters jumbled mysteriously:");
        Console.WriteLine(Question);
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
