public class CheckListGoal : Goal
{
    private int _completedTimes;
    private int _targetItems;
    private int _bonusPoints;

    public CheckListGoal(string name, string description, int points, int targetItems, int bonusPoints, bool isComplete) : base(name, description, points, isComplete)
    {
        this._targetItems = targetItems;
        this._bonusPoints = bonusPoints;
        this._completedTimes = 0;
    }

    public override int RecordEvent()
    {
        this._completedTimes++;
        if (this._completedTimes >= this._targetItems)
        {
            this.isComplete = true;
            Console.WriteLine($"Completed goal: {this.Name}. Gained {this.Points + this._bonusPoints} points.");
            return this.Points + this._bonusPoints;
        }
        else
        {
            Console.WriteLine($"Recorded event for goal: {this.Name}. Gained {this.Points} points.");
            return this.Points;
        }
    
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"Goal: {this.Name}, Description: {this.Description}, Points: {this.Points}, Bonus Points: {this._bonusPoints}, Completed: {this.isComplete}, Completed Times: {this._completedTimes}/{this._targetItems}");
    }

    public override string GetGoalRepresentation()
    {
        return $"CheckListGoal:{Name},{Description},{Points},{_targetItems},{_bonusPoints},{isComplete}";
    }
}
