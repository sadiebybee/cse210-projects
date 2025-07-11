public class ExitRoom : Room
{
    private Puzzle[] finalPuzzles;

    public ExitRoom()
    {
        Name = "Final Room";

        finalPuzzles = new Puzzle[]
        {
            new RiddlePuzzle(),
            new SequencePuzzle(),
            new WordScramblePuzzle()
        };
    }

    public override void Enter(Player player)
    {
        Console.WriteLine("You've entered the Final Room.");
        Console.WriteLine("To escape, solve three final puzzles:\n");

        foreach (var puzzle in finalPuzzles)
        {
            puzzle.Ask();
        }

        Console.WriteLine($"Congratulations, {player.Name}! You've escaped the maze!\n");
    }
}
