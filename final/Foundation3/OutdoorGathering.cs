public class OutdoorGathering : Event
{
    private string Weather;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weather) : base(title, description, date, time, address)
    {
        Weather = weather;
    }

    public override string FullDetails()
    {
        return $"{StandardDetails()}\nType: Outdoor Gathering\nWeather: {Weather}";
    }

    public override string ShortDescription()
    {
        return $"Type: Outdoor Gathering\nTitle: {GetTitle()}\nDate: {GetDate().ToString("MM/dd/yyyy")}";
    }
}
