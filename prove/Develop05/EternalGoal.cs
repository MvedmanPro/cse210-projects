public class EternalGoal : Goal
{
    private int TotalPointsEarned { get; set; }
    private int BonusPoints { get; set; }

    public EternalGoal(string name, string description, int points, bool isComplete) : base(name, description, points, isComplete)
    {
        this.TotalPointsEarned = 0;
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Recorded event for goal: {this.Name}. Gained {this.Points} points.");
        return this.Points;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"Goal: {this.Name}, Description: {this.Description}, Points: {this.Points}, Completed: {this.isComplete}");
    }

    public override string GetGoalRepresentation()
    {
        return $"EternalGoal:{Name},{Description},{Points},{isComplete}";
    }
}

