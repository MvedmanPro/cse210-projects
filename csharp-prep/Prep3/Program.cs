using System;
using System.IO.Compression;
using System.Net;
using System.Runtime.InteropServices;



internal class Program
{
    private static void Main(string[] args)
    {
    string response = "yes";
    while (response == "yes")

    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());
        int guess = -1;
        int guessCount = 0;
        while (guess != magicNumber)
        {  

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            guessCount++;

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"The number of guesses: {guessCount}");
                Console.Write("Do you want to play again? ");
                response = Console.ReadLine();
            }

        }
        
    }
}
}
