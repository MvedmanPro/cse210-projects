using Microsoft.VisualBasic;

public class Entry {
    public string _date;
    public string _prompt;
    public string _entry;
    public string _name;



    public string entryPackager() => $"{_date}: {_prompt}: {_entry}";
}