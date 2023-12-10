using System.Data;
using System.Net.Sockets;

public abstract class Event
{
    private string _eventTitle;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public Event(string eventTitle, string description, DateTime date, TimeSpan time, Address address)
    {
        this._eventTitle = eventTitle;
        this._description = description;
        this._date = date;
        this._time = time;
        this._address = address;

    }

    public string GetTitle()
    {
        return _eventTitle;
    }

    public DateTime GetDate()
    {
        return _date;
    }
    
    public string StandardDetails()
    {
        return $"Title: {_eventTitle}\nDescription: {_description}\nDate: {_date.ToString("MM/dd/yyyy")}\nTime: {_time.ToString(@"hh\:mm")}\nAddress: {_address.ToString()}";

    }
    public abstract string FullDetails();
    public abstract string ShortDescription();
}