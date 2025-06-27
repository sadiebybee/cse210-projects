public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return Points;
    }

    public override string GoalStatus()
    {
        return "[∞] " + Name;
    }

    public override string Save()
    {
        return $"Eternal|{Name}|{Description}|{Points}|{IsComplete}";
    }
}