public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    protected override double GetDistance()
    {
        return _speed * GetDuration() / 60; // km
    }

    protected override double GetSpeed() // km/h
    {
        return _speed;
    }

    protected override double GetPace() //  min per km
    {
        return 60/_speed;
    }

}