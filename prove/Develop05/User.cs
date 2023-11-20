public class User
{
    private List<Goal> goals;
    private int score;

    public User()
    {
        this.goals = new List<Goal>();
        this.score = 0;
    }

    public void CreateGoal(Goal goal)
    {
        this.goals.Add(goal);
    }

    public Goal FindGoal(string name)
    {
        foreach (var goal in this.goals)
        {
            if (goal.GetName() == name)
            {
                return goal;
            }
        }
        return null;
    }

    public void RecordEvent(Goal goal)
    {
        this.score += goal.RecordEvent();
    }

    public void DisplayGoals()
    {
        foreach (var goal in this.goals)
        {
            goal.DisplayGoal();
        }
    }

public void Save()
{
    Console.Write("Enter the name of the file you want to save your goals in: ");
    string fileName = Console.ReadLine();
    using (StreamWriter sw = new StreamWriter(fileName))
    {
        sw.WriteLine(this.score);
        foreach (var goal in this.goals)
        {
            sw.WriteLine(goal.GetGoalRepresentation());
        }
    }
    Console.WriteLine($"Goals saved successfully in {fileName}.");
}

public void Load()
{
    Console.Write("Enter the name of the file you want to load your goals from: ");
    string fileName = Console.ReadLine();
    using (StreamReader sr = new StreamReader(fileName))
    {
        this.score = int.Parse(sr.ReadLine());
        string line;
        while ((line = sr.ReadLine()) != null)
        {
            Goal goal = Goal.CreateGoal(line);
            if (goal != null)
            {
                this.goals.Add(goal);
                if (goal.GetIsComplete())
                {
                    this.score += goal.GetPoints();
                }
            }
            else
            {
                Console.WriteLine($"Could not create a goal from the line: {line}");
            }
        }
    }
    Console.WriteLine($"Goals loaded successfully from {fileName}. Your current score is {this.score}.");
}
}