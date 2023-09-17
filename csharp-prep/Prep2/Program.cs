using System;

Console.Write("What is your grade percentage? ");
string userInput = Console.ReadLine();
int userPercentage = int.Parse(userInput);
int lastDigit = userPercentage % 10;

string letter = "";
string sign = "";

if (userPercentage >= 90)
{
    letter = "A";
}
else if (userPercentage >= 80)
{
    letter = "B";
    if (lastDigit >= 7)
    {
        sign = "+";
    }
    else if (lastDigit <3)
    {
        sign = "-";
    }
    else
    {
        sign = "";
    }
}
else if (userPercentage >= 70)
{
    letter = "C";
        if (lastDigit >= 7)
    {
        sign = "+";
    }
    else if (lastDigit <3)
    {
        sign = "-";
    }
        else
    {
        sign = "";
    }
}

else if (userPercentage >= 60)
{
    letter = "D";
    if (lastDigit >= 7)
    {
        sign = "+";
    }
    else if (lastDigit <3)
    {
        sign = "-";
    }
    else
    {
        sign = "";
    }
}
else
{
    letter = "F";
}

Console.WriteLine($"Your grade is: {letter}{sign}");

if (userPercentage >=70)
{
    Console.WriteLine("Congradulations! You have passed the course!");
}
else
{
    Console.WriteLine("You have not passed the course, ask for a different project from your instructor.");
}

