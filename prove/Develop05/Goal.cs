using System;
using System.IO;
using System.Collections.Generic;

public abstract class Goal
{
    protected string Name { get; set; }
    protected string Description { get; set; }
    protected int Points { get; set; }
    protected bool isComplete { get; set; }

    public Goal(string name, string description, int points, bool isComplete)
    {
        this.Name = name;
        this.Description = description;
        this.Points = points;
        this.isComplete = isComplete;
    }

    public abstract int RecordEvent();
    public abstract void DisplayGoal();
    public abstract string GetGoalRepresentation();

    public string GetName()
    {
        return Name;
    }

    public void SetName(string value)
    {
        Name = value;
    }

        public int GetPoints()
    {
        return Points;
    }

    public bool GetIsComplete()
    {
        return isComplete;
    }

    public static Goal CreateGoal(string details)
{
    var splitDetails = details.Split(':');
    if (splitDetails.Length != 2 || splitDetails[0].Length == 0 || splitDetails[1].Length == 0) 
    {
        throw new ArgumentException("Invalid goal details format.");
    }

    var goalType = splitDetails[0];
    var goalDetails = splitDetails[1].Split(',');
    if (goalDetails.Length < 4) 
    {
        throw new ArgumentException("Invalid goal details format.");
    }

    var name = goalDetails[0];
    var description = goalDetails[1];
    var points = int.Parse(goalDetails[2]);
    var isComplete = bool.Parse(goalDetails[3]);

    Console.WriteLine($"Goal type: {goalType}");
    Console.WriteLine($"Goal name: {name}");
    Console.WriteLine($"Goal description: {description}");
    Console.WriteLine($"Goal points: {points}");
    Console.WriteLine($"Goal isComplete: {isComplete}");

    switch (goalType)
    {
        case "SimpleGoal":
            return new SimpleGoal(name, description, points, isComplete);
        case "EternalGoal":
            return new EternalGoal(name, description, points, isComplete);
        case "CheckListGoal":
            if (goalDetails.Length < 6) 
            {
                throw new ArgumentException("Invalid goal details format.");
            }
            var targetItems = int.Parse(goalDetails[4]);
            var bonusPoints = int.Parse(goalDetails[5]);
            Console.WriteLine($"Goal targetItems: {targetItems}");
            Console.WriteLine($"Goal bonusPoints: {bonusPoints}");
            return new CheckListGoal(name, description, points, targetItems, bonusPoints, isComplete);
        default:
            return null;
    }
}

}