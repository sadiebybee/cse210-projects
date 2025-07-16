using System;

public class StartRoom : Room
{
    public StartRoom()
    {
        SetName("First Room");
    }

    public override void Enter(Player player)
    {
        Console.WriteLine($"Welcome, {player.GetName()}! Your adventure begins.\n");

        Console.WriteLine("You awaken in a dim, stone chamber. The air is cold and silent.");
        Console.WriteLine("A carved message on the wall reads:");
        Console.WriteLine("\"Only those who solve the riddles of the maze may return to the world beyond.\"\n");


        Console.WriteLine($"Starting Health: {player.GetHealthDisplay()}\n");
    }
}
