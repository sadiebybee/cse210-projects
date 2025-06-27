public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
    public bool IsComplete { get; set; }

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
        IsComplete = false;
    }

    public void MarkComplete()
    {
        IsComplete = true;
    }

    public abstract int RecordEvent(); // return points earned
    public abstract string GoalStatus(); // return string status for display
    public abstract string Save(); // return string to save to file

}