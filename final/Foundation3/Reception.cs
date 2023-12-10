public class Reception : Event
{
    private string RSVP_Email;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvp_email) : base(title, description, date, time, address)
    {
        RSVP_Email = rsvp_email;
    }

    public override string FullDetails()
    {
        return $"{StandardDetails()}\nType: Reception\nRSVP Email: {RSVP_Email}";
    }

    public override string ShortDescription()
    {
        return $"Type: Reception\nTitle: {GetTitle()}\nDate: {GetDate().ToString("MM/dd/yyyy")}";
    }
}
