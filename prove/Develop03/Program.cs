using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the scripture memorization program!\nDo you want to memorize a single verse or multiple verses? (single/multiple)");
        string response = Console.ReadLine().ToLower();

        List<string> verses = new List<string>();
        Reference reference;

        if (response == "single")
        {
            verses.Add("Trust in the Lord with all your heart and lean not on your own understanding;");
            reference = new Reference("Proverbs", "3", "5");
        }
        else
        {
            verses.Add("Trust in the Lord with all your heart and lean not on your own understanding;");
            verses.Add("In all your ways acknowledge Him, And He shall direct your paths.");
            reference = new Reference("Proverbs", "3", "5", "6");
        }

        
       bool restart = true;
       while (restart)
       { 
           Scripture scripture = new Scripture(verses, reference);
           while (!scripture.IsCompletelyHidden())
           {
               scripture.Display();
               Console.WriteLine("Press Enter to hide the next three words...");
               Console.ReadLine();
               scripture.HideNextWords(3);
               Console.Clear();
           }

           scripture.Display();
           Console.WriteLine("All words are hidden!");

           Console.WriteLine("Do you want to start the memorization again? (yes/no)");
           string restartResponse = Console.ReadLine().ToLower();
           restart = restartResponse == "yes";
       }
   }
}


