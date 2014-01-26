using System;
//3.Write a program that prints to the console which day of the week is today. Use System.DateTime.

class WhichDayIsToday
{
    static void Main()
    {
        DateTime today = new DateTime();
        today = DateTime.Today;
        Console.WriteLine(today.DayOfWeek);
    }
}
