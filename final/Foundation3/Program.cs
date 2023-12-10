using System;
class Program
{
    static void Main(string[] args)
    {
        // Create an address
        Address lectureAddress = new Address("2497 Forest Drve", "Washington", "VA", "USA");
        Address receptionAddress = new Address("2921 Ross Street", "Metropolis", "IL", "USA");
        Address gatheringAddress = new Address("Times Square", "New York", "NY", "USA");

        // Create a lecture event
        Console.WriteLine("--------------");
        Lecture lecture = new Lecture("Modern Engineering", "A talk on the modern engineering standards" , DateTime.Today, new TimeSpan(11, 0, 0), lectureAddress, "Dr. Rose", 100);
        Console.WriteLine("About the event: ");
        Console.WriteLine(lecture.StandardDetails());
        Console.WriteLine("--------------");
        Console.WriteLine("See full details of the event here: ");
        Console.WriteLine(lecture.FullDetails());
        Console.WriteLine("--------------");
        Console.WriteLine("See short description of the event: ");
        Console.WriteLine(lecture.ShortDescription());

        // Create a reception event
        Console.WriteLine("--------------");
        Reception reception = new Reception("Birthday Event", "Celebration of birth", DateTime.Today, new TimeSpan(21, 0, 0), receptionAddress, "rsvp@responce.com");
        Console.WriteLine("About the event: ");
        Console.WriteLine(reception.StandardDetails());
        Console.WriteLine("--------------");
        Console.WriteLine("See full details of the event here: ");
        Console.WriteLine(reception.FullDetails());
        Console.WriteLine("--------------");
        Console.WriteLine("See short description of the event: ");
        Console.WriteLine(reception.ShortDescription());

        // Create an outdoor gathering event
        Console.WriteLine("------------");
        OutdoorGathering gathering = new OutdoorGathering("Quizes with strangers", "An outdoor recorded interview-quiz", DateTime.Today, new TimeSpan(19, 0, 0), gatheringAddress, "Cloudy");
        Console.WriteLine("About the event: ");
        Console.WriteLine(gathering.StandardDetails());
        Console.WriteLine("--------------");
        Console.WriteLine("See full details of the event here: ");
        Console.WriteLine(gathering.FullDetails());
        Console.WriteLine("--------------");
        Console.WriteLine("See short description of the event: ");
        Console.WriteLine(gathering.ShortDescription());
    }
}
