public class StartRoom : Room
{
    public StartRoom()
    {
        Name = "Start Room";
    }

    public override void Enter(Player player)
    {
        Console.WriteLine($"Welcome {player.Name}! You are in the Start Room.");
        Console.WriteLine("Find the exit by solving puzzles!");
    }
}
