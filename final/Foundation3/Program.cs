using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 Main St", "Rexburg", "ID", "USA");

        Lecture lecture = new Lecture("Tech Talk", "C# Learning", "April 10", "10:00 AM", address, "Dr. Brown", 100);
        Reception reception = new Reception("Wedding", "Celebrate", "May 5", "6:00 PM", address, "rsvp@email.com");
        OutdoorGathering outdoor = new OutdoorGathering("Picnic", "Family fun", "June 1", "12:00 PM", address, "Sunny");

        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine();

        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine();

        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine(outdoor.GetShortDescription());
    }
}