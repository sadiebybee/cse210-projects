class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            return Points;
        }
        return 0;
    }

    public override string GoalStatus()
    {
        return (IsComplete ? "[X] " : "[ ] ") + Name;
    }

    public override string Save()
    {
        return $"Simple|{Name}|{Description}|{Points}|{IsComplete}";
    }
}