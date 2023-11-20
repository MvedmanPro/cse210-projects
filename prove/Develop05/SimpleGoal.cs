public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points, isComplete)
    {
    }

    public override int RecordEvent()
    {
        this.isComplete = true;
        Console.WriteLine($"Completed goal: {this.Name}. Gained {this.Points} points.");
        return this.Points;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"Goal: {this.Name}, Description: {this.Description}, Points: {this.Points}, Completed: {this.isComplete}");
    }

    public override string GetGoalRepresentation()
    {
        return $"SimpleGoal:{Name},{Description},{Points},{isComplete}";
    }
}
