using System;
using System.Collections.Generic;

public class RiddlePuzzle : Puzzle
{
    private List<(string question, string answer)> riddles;
    private static int riddleIndex = 0;

    public RiddlePuzzle()
    {
        riddles = new List<(string, string)>
        {
            ("What has keys but can't open locks?", "keyboard"),
            ("What has a face and two hands, but no arms or legs?", "clock")
        };
    }

    public override void Ask()
    {
        if (riddleIndex >= riddles.Count)
            riddleIndex = 0;

        var currentRiddle = riddles[riddleIndex];
        riddleIndex++;

        Console.WriteLine("Puzzle:");
        Console.WriteLine(currentRiddle.question);
        Console.Write("> ");
        string input = Console.ReadLine()?.ToLower();

        if (input == currentRiddle.answer)
        {
            Console.WriteLine("Correct! You may proceed.\n");
        }
        else
        {
            Console.WriteLine($"Incorrect. The correct answer was: {currentRiddle.answer}\n");
        }
    }
}
