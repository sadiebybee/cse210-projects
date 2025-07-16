using System;

public class PuzzleRoom : Room
{
    private Puzzle puzzle;

    public PuzzleRoom(Puzzle inputPuzzle, string roomName)
    {
        puzzle = inputPuzzle;
        SetName(roomName);
    }

    public override void Enter(Player player)
    {
        Console.WriteLine($"You have entered the {GetName()}.");
        Console.WriteLine($"Current Health: {player.GetHealthDisplay()}\n");
        puzzle.Ask(player);
    }
}
