﻿namespace CSharpFundamentals.Sections;

/// <summary>
/// Working with Dates
/// </summary>
public static class Section5
{
    public static void Run()
    {
        DateTimes();
        DateSpans();
    }

    private static void DateTimes()
    {
        Console.WriteLine("Start -> DateTime");

        var dateTime = new DateTime(1999, 12, 16);
        var now = DateTime.Now;
        var today = DateTime.Today;

        Console.WriteLine("Hour: " + now.Hour);
        Console.WriteLine("Minute: " + now.Minute);

        var tomorrow = now.AddDays(1);
        var yesterday = now.AddDays(-1);

        Console.WriteLine(now.ToLongDateString());
        Console.WriteLine(now.ToShortDateString());
        Console.WriteLine(now.ToLongTimeString());
        Console.WriteLine(now.ToShortTimeString());
        Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

        Console.WriteLine("Finish -> DateTime");
    }

    public static void DateSpans()
    {
        // Creating
        var timeSpan = new TimeSpan(1, 2, 3);

        var timeSpan1 = new TimeSpan(1, 0, 0);
        var timeSpan2 = TimeSpan.FromHours(1);

        var start = DateTime.Now;
        var end = DateTime.Now.AddMinutes(2);
        var duration = end - start;

        Console.WriteLine("Duration: " + duration);

        //Properties
        Console.WriteLine("Minutes: " + timeSpan.Minutes);
        Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

        //Add
        Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
        Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

        //ToString
        Console.WriteLine("ToString: " + timeSpan.ToString());

        //Parse
        Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
    }
}
