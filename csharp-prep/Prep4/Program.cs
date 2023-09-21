using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    { //create a list
        List<int> numbers = new List<int>();

        int userNumber = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished ");
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            //Add numbers from the user to the list until user number is 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        //Find the sum

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        //Find the average
        float average = ((float)sum)/numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Find the max
        int max = numbers[0];

        foreach(int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
        
    }

}