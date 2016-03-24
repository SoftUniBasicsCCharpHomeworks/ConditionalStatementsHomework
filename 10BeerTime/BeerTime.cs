using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        Console.WriteLine("Enter time in format \"hh:mm tt\"");
        string input = Console.ReadLine();
        string format = "h:mm tt";
        DateTime time = DateTime.ParseExact(input, format, CultureInfo.InvariantCulture);
        DateTime startTime = DateTime.Parse("1:00 PM");
        DateTime endTime = DateTime.Parse("2:59 AM");
        if (time >= startTime || time <= endTime)
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
    }
}

