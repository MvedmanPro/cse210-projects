using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {

        var fulldate = DateTime.Now; //declares a variable named fulldate and assigns it the value of DateTime.Now, which is a property that returns the current date and time as a DateTime object.
        string date = fulldate.ToString("MM/dd/yyyy");//declares a variable named date and assigns it the value of fulldate.ToString("MM/dd/yyyy"), a method.

        // declares variables and assigns it a new object of types:
        // Entry/PromptGeneration/Journal/User
        Entry entry1 =  new Entry();
        PromptGeneration promptGenerator = new PromptGeneration();
        Journal journal = new Journal();
        User user = new User();

        //Greeting, getting user's information
        Console.WriteLine("\nWelcome To Your Journal App");
        Console.Write("Enter your first name: ");
        user._firstName = Console.ReadLine();
        Console.Write("Enter your last name: ");
        user._lastName = Console.ReadLine();
        Console.Write("Enter your major: ");
        user._major = Console.ReadLine();


       //menu selections
        while(true)
        {
            Console.WriteLine("Please choose from the menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            //reads user input 
            string input = Console.ReadLine();

         switch (input)
        {
          case "1": // Write a new entry
            string prompt = promptGenerator.GetPrompt();
            Console.WriteLine($"Today's prompt: {prompt}");

            //gets user responce and stores it in the variable
            string entry = Console.ReadLine();
            //sends values to the entry class object
            entry1._date = date;
            entry1._entry = entry;
            entry1._prompt = prompt;
            //uses the object method to package data
            string packagedEntry = entry1.entryPackager();

            // adds the package to the journal
            journal._entries.Add(packagedEntry);
            break;
        case "2": // Displays the journal
            Console.WriteLine("Your journal entries are:");
            user.displayName();
            journal.displayEntries();
            break;
        case "3": // Saves the entries to a file
            journal.saveEntries();
            Console.WriteLine($"Your journal has been saved.");
            break;
        case "4": // Loads the journal from a file
            journal.loadEntries();
            Console.WriteLine($"Your journal has been loaded from the file.");
            break;
        case "5": // Exits
            Console.WriteLine("Thank you for using the journal app. Come back later!");
            Environment.Exit(0);
            break;
        default: // Invalid input
            Console.WriteLine("Invalid input. Please enter a number from 1 to 5.");
            break;
        }
        }

    }
}
