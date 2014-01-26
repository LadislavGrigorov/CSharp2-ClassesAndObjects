using System;
//2.Write a program that generates and prints to the console 10 random values in the range [100, 200].

class TenRandomValues
{
    private static Random rand = new Random();
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(rand.Next(100,201));
        }
    }
}
