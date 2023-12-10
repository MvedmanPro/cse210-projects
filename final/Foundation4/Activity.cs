public class Activity
{
    private DateTime _date;
    private int _duration;

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    protected int GetDuration()
    {
        return _duration;
    }
    protected virtual double GetDistance()
    {
        return 0;
    }
    protected virtual double GetSpeed()
    {
        return 0;
    }
    protected virtual double GetPace()
    {
        return 0;
    }
    public string GetSummary()
   {
    // formats the date as "dd MMM yyyy"
    string formattedDate = _date.ToString("dd MMM yyyy");

    // the type of activity
    string activityType = this.GetType().Name;

    // the duration in min
    string formattedDuration = $"{_duration} min";

    // the distance, speed, and pace with appropriate formatting and units
    string formattedDistance = $"Distance {GetDistance():F1} km";
    string formattedSpeed = $"Speed {GetSpeed():F1} km/h";
    string formattedPace = $"Pace {GetPace():F1} min per km";

    // final summary using formatted strings
    return $"{formattedDate} {activityType} ({formattedDuration})- {formattedDistance}, {formattedSpeed}, {formattedPace}";
}

}