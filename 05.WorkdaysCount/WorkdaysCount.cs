using System;
//5. Write a method that calculates the number of workdays between today and given date, passed as parameter. Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

class WorkdaysCount
{
    static void PrintWorkdays(DateTime today, DateTime inputDate)
    {
        int workDays = 0;
        DateTime[] holidays = new DateTime[14];
        holidays[0] = new DateTime(today.Year, 1, 1);
        holidays[1] = new DateTime(today.Year, 3, 3);
        holidays[2] = new DateTime(today.Year, 4, 18);
        holidays[3] = new DateTime(today.Year, 4, 19);
        holidays[4] = new DateTime(today.Year, 4, 20);
        holidays[5] = new DateTime(today.Year, 5, 1);
        holidays[6] = new DateTime(today.Year, 5, 6);
        holidays[7] = new DateTime(today.Year, 5, 24);
        holidays[8] = new DateTime(today.Year, 9, 6);
        holidays[9] = new DateTime(today.Year, 11, 1);
        holidays[10] = new DateTime(today.Year, 12, 24);
        holidays[11] = new DateTime(today.Year, 12, 25);
        holidays[12] = new DateTime(today.Year, 12, 26);
        holidays[13] = new DateTime(today.Year, 12, 31);
        while (today <= inputDate)
        {
            if (today.DayOfWeek != DayOfWeek.Saturday && today.DayOfWeek != DayOfWeek.Sunday) //checks if it's Saturday or Sunday
            {
                bool isNotHoliday = true;
                for (int i = 0; i < holidays.Length; i++)
                {
                    if (today.Date == holidays[i].Date)                                     //checks if it's holiday or not
                    {
                        isNotHoliday = false;
                    }
                }
                if (isNotHoliday)                                                       //if its not holiday count +1 working day
                {
                    workDays++;
                }
            }

            today = today.AddDays(1);                                                    //adds next day
        }
        Console.WriteLine(workDays);                                                    //prints the final result
    }
    static void Main()
    {
        DateTime today = DateTime.Today;
        Console.Write("Enter day: ");
        int day = int.Parse(Console.ReadLine());
        Console.Write("Enter month: ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());
        DateTime inputDate = new DateTime(year, month, day);
        PrintWorkdays(today, inputDate);
    }
}
