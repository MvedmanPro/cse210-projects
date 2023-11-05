using System.Security.Principal;
using Microsoft.Win32.SafeHandles;

public class Activity 
{
    private string _title;
    private int _time;
    private string _message = "You may begin in...";

    
    public Activity (string title, int time)
    {
        _title = title;
        _time = time;
    }

    public void GetTitle()
    {
        Console.WriteLine($"Welcome to the {_title} Activity");
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public int GetTime()
    {
        Console.WriteLine("How long, in seconds, would you like for this session?");
        int userSeconds = Int32.Parse(Console.ReadLine());
        _time = userSeconds;
        return userSeconds;
    }

    public void SetTime(int time)
    {
        _time = time;
    }

     // Methods
    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Animation animation = new Animation();
        animation.RunAnimation();
    }

    public void GetDone()
    {
        Console.WriteLine($"\nWell done!!");
        Console.WriteLine($"\nYou have completed another {_time} seconds of the {_title} Activity!");
        Animation animation2= new Animation();
        animation2.RunAnimation();
        
    }
     public void CountDown(int time1)
    {
        Console.WriteLine();  
        for (int i = time1; i > 0; i--)
        {
            Console.Write($"{_message}{i}");
            Thread.Sleep(1000);
            string blank = new string('\b', (_message.Length + 5)); 
            Console.Write(blank);
        }
        Console.WriteLine($"Go:              "); 
    }


}
