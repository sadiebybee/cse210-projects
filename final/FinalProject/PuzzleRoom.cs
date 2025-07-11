public class PuzzleRoom : Room
{
    private Puzzle puzzle;

    public PuzzleRoom(Puzzle newPuzzle)
    {
        puzzle = newPuzzle;
        Name = "Puzzle Room";
    }

    public override void Enter(Player player)
    {
        Console.WriteLine($"You have entered a {Name}.");
        puzzle.Ask();
    }
}
