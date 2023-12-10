
public class Lecture : Event 
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity): base(title, description, date, time, address)
    {
        this._speakerName = speaker;
        this._capacity = capacity;
    }

    public override string FullDetails()
    {
        return $"{StandardDetails()}\nType: Lecture\nSpeaker:{_speakerName}\nCapacity: {_capacity}";
    }
    public override string ShortDescription()
    {
        return $"Type: Lecture\nTitle: {GetTitle()}\nDate: {GetDate().ToString("MM/dd/yyyy")}";
    }
}
