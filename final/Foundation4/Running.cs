public class Running : Activity
{
    private double _distance; // in km

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    protected override double GetDistance() // in km
    {
        return _distance;
    }

    protected override double GetSpeed()
    {
        return _distance / GetDuration() * 60; //speed in km/h
    }

    protected override double GetPace()
    {
        return 60 / GetSpeed(); // pace in min per km
    }
}