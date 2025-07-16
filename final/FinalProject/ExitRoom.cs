public class ExitRoom : Room
{
    private Puzzle[] finalPuzzles;

    public ExitRoom()
    {
        SetName("Final Room");

        finalPuzzles = new Puzzle[]
        {
            new RiddlePuzzle(),
            new SequencePuzzle(),
            new WordScramblePuzzle()
        };
    }

    public override void Enter(Player player)
    {
        Console.WriteLine($"You have entered the {GetName()}.");
        Console.WriteLine("At last, you find a heavy iron door with ancient symbols.");
        Console.WriteLine("A voice booms from above:");
        Console.WriteLine("\"Prove yourself one final time to earn your freedom.\"\n");

        foreach (Puzzle puzzle in finalPuzzles)
        {
            puzzle.Ask(player);
        }

        Console.WriteLine("You emerge into daylight, breathless and worn.");
        Console.WriteLine($"Final Health: {player.GetHealthDisplay()}");
        Console.WriteLine("The maze fades into mist behind you. You have survived.");
    }
}
