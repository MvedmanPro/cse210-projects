using System;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Marylyn", "Fractions");
        string math1 = assignment.GetSummary();
        Console.WriteLine(math1);
        Console.WriteLine("------------------");

        MathAssignment assignment2 = new MathAssignment("Mary", "Comparing Numbers", "Section 8.8", "Problem 2-9");
        string math_student = assignment2.GetSummary();
        string math_topic = assignment2.GetHomeworkList();
        Console.WriteLine(math_student);
        Console.WriteLine(math_topic);
        Console.WriteLine("------------------");

        WritingAssignment assignment3 = new WritingAssignment("Marylyn Waters", "World War ||", "The Causes of World War ||");
        string writing_student = assignment3.GetSummary();
        Console.WriteLine(writing_student);
        string writing_title = assignment3.GetWritingInformation();
        Console.WriteLine(writing_title);
        Console.WriteLine("------------------");
    }
} 