using System;

enum DayType
{
    Weekday,
    Weekend
}

record Book(string title, string author, double price);

class Program
{
    static void Main(string[] args)
    {
        // asking user for day
        Console.Write("Enter the day: ");
        string day = Console.ReadLine();

        // checking weekend
        if (day == "Friday" || day == "Saturday")
        {
            Console.WriteLine("It is: " + DayType.Weekend);
        }
        else
        {
            Console.WriteLine("It is: " + DayType.Weekday);
        }

        // creating first book object
        Book b1 = new Book("C# Basics", "John Doe", 499.99);

        // creating second book using with expression
        Book b2 = b1 with { title = "Advanced C#", price = 699.99 };

        // printing the first object
        Console.WriteLine(b1);
    }
}
