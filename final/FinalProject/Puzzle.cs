public abstract class Puzzle
{
    public string Question { get; set; }
    public string Answer { get; set; }

    public abstract void Ask();
}
