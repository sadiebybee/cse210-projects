public class QuestManager
{
    private List<Goal> goals = new List<Goal>();
    public int Score { get; set; }

    public QuestManager()
    {
        Score = 0;
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter point value: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times to complete? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus points on completion? ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new CheckListGoal(name, description, points, 0, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("Your Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GoalStatus()}");
        }
    }

    public void SaveToFile()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(Score);
                foreach (Goal goal in goals)
                {
                    writer.WriteLine(goal.Save());
                }
            }
            Console.WriteLine($"Goals successfully saved.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error saving goals to {filename}: {e.Message}");
        }
    }

    public void LoadFromFile()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            Score = int.Parse(lines[0]);
            goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                string type = parts[0];

                switch (type)
                {
                    case "Simple":
                        goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]))
                        { IsComplete = bool.Parse(parts[4]) });
                        break;
                    case "Eternal":
                        goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                        break;
                    case "Checklist":
                        goals.Add(new CheckListGoal(
                            parts[1], parts[2], int.Parse(parts[3]),
                            int.Parse(parts[6]), int.Parse(parts[4]), int.Parse(parts[5])));
                        break;
                }
            }
            Console.WriteLine("Goals successfully loaded.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }

        if (int.TryParse(Console.ReadLine(), out int choice) &&
            choice >= 1 && choice <= goals.Count)
        {
            int pointsEarned = goals[choice - 1].RecordEvent();
            Score += pointsEarned;

            Console.WriteLine($"You earned {pointsEarned} points!");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    public void DeleteGoal()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("There are no goals to delete.");
            return;
        }

        Console.WriteLine("Which goal would you like to delete?");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GoalStatus()}");
        }

        Console.Write("Enter the number of the goal to delete: ");
        if (int.TryParse(Console.ReadLine(), out int index) &&
            index >= 1 && index <= goals.Count)
        {
            goals.RemoveAt(index - 1);
            Console.WriteLine("Goal successfully deleted.");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }
}