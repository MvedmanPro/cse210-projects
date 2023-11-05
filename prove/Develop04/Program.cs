using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("\nWelcome to the Mindfulness Program\n");
        Options choice = new Options();
        int seconds;

        int action = 0;
        while (action != 4)
        {

            action = choice.UserChoice();
            switch (action)
            {
                case 1:
                    // Start Breathing Activity
                    Console.Clear();
                    BreathingActivity breathing = new BreathingActivity("Breathing", 0);
                    breathing.GetTitle();
                    breathing.GetActivityDescription();
                    seconds = breathing.GetTime();
                    breathing.GetReady();
                    breathing.Breathing(seconds);
                    breathing.GetDone();
                    break;
                case 2:
                    //Start Reflecting Activity
                    Console.Clear();
                    ReflectingActivity reflecting = new ReflectingActivity("Reflecting", 0);
                    reflecting.GetTitle();
                    reflecting.GetActivityDescription();
                    seconds = reflecting.GetTime();
                    reflecting.GetReady();
                    reflecting.ShowPrompt(seconds);
                    reflecting.GetDone();
                    break;
                case 3:
                    //Start Listing Activity
                    Console.Clear();
                    ListingActivity listing = new ListingActivity("Listing", 0);
                    listing.GetTitle();
                    listing.GetActivityDescription();
                    seconds = listing.GetTime();
                    listing.GetReady();
                    listing.ReturnPrompt(seconds);
                    listing.GetDone();
                    break;
                case 4:
                    // Exit
                    Console.WriteLine("\nThank you for using the Mindfulness Program!\n");
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }
}
