using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        DateTime currentDate = DateTime.Now;
        // creates a list to hold activities
        List<Activity> activities = new List<Activity>();

        // creates an instance of each activity type with data
        Cycling cyclingActivity = new Cycling(currentDate, 60, 3.0); //date, duration, speed
        Running runningActivity = new Running(currentDate, 30, 3.2); //date, duration, distance
        Swimming swimmingActivity = new Swimming(currentDate, 45, 20); //date, duration, number of laps

        // adds activities to the list
        activities.Add(cyclingActivity);
        activities.Add(runningActivity);
        activities.Add(swimmingActivity);

        // iterates through the list and calls GetSummary on each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
