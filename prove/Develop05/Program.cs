using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        User user = new User();
        while (true)
        {   
            Console.WriteLine("Welcome to Eternal Quest Program!");
            Console.WriteLine("--------------");
            Console.WriteLine("1. Create a goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Display goals");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Exit");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                Console.Write("Enter the type of the goal: (1. Simple, 2. Eternal, 3. Checklist): ");
                int type = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the name of the goal: ");
                string name = Console.ReadLine();
                Console.Write("Enter the description of the goal: ");
                string description = Console.ReadLine();
                Console.Write("Enter the points for the goal: ");
                int points = Convert.ToInt32(Console.ReadLine());

                if (type == 1 )
                {
                    user.CreateGoal(new SimpleGoal(name, description, points, false));
                }
                else if (type == 2)
                {
                    user.CreateGoal(new EternalGoal(name, description, points, false));
                }
                else if (type == 3)
                {
                    Console.Write("Enter the target items for the goal: ");
                    int targetItems = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the bonus points for the goal: ");
                    int bonusPoints = Convert.ToInt32(Console.ReadLine());
                    user.CreateGoal(new CheckListGoal(name, description, points, targetItems, bonusPoints, false));
                }
                break;
                case 2:
                Console.Write("Enter the name of the goal: ");
                string goalName = Console.ReadLine();
                Goal goal = user.FindGoal(goalName);
                if (goal != null)
                {
                    user.RecordEvent(goal);
                }
                else
                {
                    Console.WriteLine("Goal not found.");
                }
                break;
                case 3:
                user.DisplayGoals();
                break;
                case 4:
                user.Save();
                break;
                case 5:
                user.Load();
                break;
                case 6:
                return;
            }
        }
    }
}
