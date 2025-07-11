public class SequencePuzzle : Puzzle
{
    private static int sequenceIndex = 0;

    private List<(string question, string answer)> sequences = new List<(string, string)>
    {
        ("What comes next in the sequence: 2, 4, 6, 8, ?", "10"),
        ("What comes next in the sequence: 5, 10, 15, 20, ?", "25")
    };

    public SequencePuzzle()
    {
        if (sequenceIndex >= sequences.Count)
            sequenceIndex = 0;

        var current = sequences[sequenceIndex];
        Question = current.question;
        Answer = current.answer;

        sequenceIndex++;
    }

    public override void Ask()
    {
        Console.WriteLine("Sequence Puzzle:");
        Console.WriteLine(Question);
        Console.Write("> ");
        string input = Console.ReadLine()?.Trim();

        if (input == Answer)
            Console.WriteLine("Correct!\n");
        else
            Console.WriteLine($"Incorrect. The correct answer was: {Answer}\n");
    }
}
