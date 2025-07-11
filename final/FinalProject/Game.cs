public class Game
{
    private Player player;

    public void Start()
    {
        Console.WriteLine("Welcome to MazeQuest!");
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        player = new Player(name);
        Console.Clear();

        Room[] rooms = new Room[]
        {
            new StartRoom(),
            new PuzzleRoom(new RiddlePuzzle()),
            new PuzzleRoom(new SequencePuzzle()),
            new PuzzleRoom(new WordScramblePuzzle()),
            new ExitRoom()
        };

        foreach (Room room in rooms)
        {
            room.Enter(player);
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        Console.WriteLine("Thanks for playing MazeQuest!");
    }
}
