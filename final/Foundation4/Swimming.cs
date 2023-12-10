public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    protected override double GetDistance()
    {
        return _laps * 50 / 1000.0; // converts laps to kilometers
    }

    protected override double GetSpeed()
    {
        return 60 / GetPace(); // in km/h
    }

    protected override double GetPace()
    {
        return GetDuration() / GetDistance(); // pace in min per km
    }

}