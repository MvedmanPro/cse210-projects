public class Options
{
    public int UserChoice()
    {
        Console.WriteLine("\nPlease choose an activity:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select an option from the menu: ");

        string input = Console.ReadLine();
        int choice;

        // Validate user input
        while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
        {
            Console.Write("Invalid input. Please enter a number between 1 and 4: ");
            input = Console.ReadLine();
        }

        return choice;
    }
}
