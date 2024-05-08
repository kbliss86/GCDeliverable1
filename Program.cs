// Starter Code from Starter Modules
using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Please enter your score: ");

        int score = int.Parse(Console.ReadLine());

        if (score >= 90)
        {
            Console.WriteLine("You got an A!");
        }
        //add your additional conditions here
        else
        {
            Console.WriteLine("You failed :(");
        }
    }
}