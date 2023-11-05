using System.Net.NetworkInformation;
using System.Threading;

public class BreathingActivity: Activity
{
    //Attributes
    private string _message1 = "Breath in...";
    private string _message2 = "Breath out...";
    private string _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

    //Constructors/Methods

    public BreathingActivity(string title, int time) : base(title, time)
    {

    }
    public void GetActivityDescription()
    {
        Console.WriteLine(_description);
    }

    public void Breathing(int seconds)
    {
        Console.WriteLine();
        int secondsTimer = 0;
        while (secondsTimer < seconds)
        {
            Console.WriteLine();
            for (int i = 6; i > 0; i--)
            {
                Console.Write($"{_message1}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_message1.Length + 2));
                Console.Write(blank);
                secondsTimer += 1;
            }
            Console.WriteLine($"{_message1}  ");
            for (int i = 7; i > 0; i--)
            {
                Console.Write($"{_message2}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_message2.Length + 2));
                Console.Write(blank);
                secondsTimer += 1;
            }
            Console.WriteLine($"{_message2}   ");
        }
    }
}