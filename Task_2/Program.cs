﻿internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();
        if(input.Length < 20)
        {
            input = input.PadRight(20, '*');
        }
        else if(input.Length > 20) {
            input = input.Substring(0, 20);
        }
        Console.WriteLine(input);
    }
}