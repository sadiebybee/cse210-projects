public class Game
{
    private Player player;

    public void Start()
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to Puzzle Quest!");
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        player = new Player(name);
        Console.Clear();

        Room[] rooms = new Room[]
        {
            new StartRoom(),
            new PuzzleRoom(new RiddlePuzzle(), "Riddle Room"),
            new PuzzleRoom(new SequencePuzzle(), "Sequence Room"),
            new PuzzleRoom(new WordScramblePuzzle(), "Scramble Room"),
            new ExitRoom()        };

        foreach (Room room in rooms)
        {
            room.Enter(player);
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        Console.WriteLine("Thanks for playing Puzzle Quest!");
    }
}
