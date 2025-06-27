class CheckListGoal : Goal
{
    private int TimesCompleted;
    private int TargetCount;
    private int BonusPoints;
    public CheckListGoal(string name, string description, int points, int timesCompleted, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        TimesCompleted = timesCompleted;
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (!IsComplete)
        {
            TimesCompleted++;

            if (TimesCompleted >= TargetCount)
            {
                IsComplete = true;
                return Points + BonusPoints;
            }

            return Points;
        }

        return 0;   
    }

    public override string GoalStatus()
    {
        string status = IsComplete ? "[X] " : "[ ] ";
        return $"{status}{Name} ({TimesCompleted}/{TargetCount})";
    }

    public override string Save()
    {
        return $"Checklist|{Name}|{Description}|{Points}|{TargetCount}|{BonusPoints}|{TimesCompleted}";
    }
}