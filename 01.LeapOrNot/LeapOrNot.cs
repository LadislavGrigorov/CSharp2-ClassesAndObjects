using System;
//1. Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

class LeapOrNot
{
    static void Main()
    {
        int yearInput = int.Parse(Console.ReadLine());
        bool yearIsLeap = DateTime.IsLeapYear(yearInput);
        if (yearIsLeap)
        {
            Console.WriteLine("{0} is leap year", yearInput);
        }
        else
        {
            Console.WriteLine("{0} is not leap year", yearInput);
        }
    }
}
