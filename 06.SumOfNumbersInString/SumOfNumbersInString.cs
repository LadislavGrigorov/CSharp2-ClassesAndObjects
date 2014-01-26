using System;
//You are given a sequence of positive integer values written into a string, separated by spaces. Write a function that reads these values from given string and calculates their sum. Example:
//		string = "43 68 9 23 318"  result = 461

class SumOfNumbersInString
{
    static void Main()
    {
        string inputString = "43 68 9 23 318";
        int sum = 0;
        string[] numbers = inputString.Split(' '); //splits the string in numbers separeted by ' ' in string array
        foreach (string number in numbers)
        {
            sum += int.Parse(number);
        }
        Console.WriteLine(sum);
    }
}
