﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            //Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            //Console.WriteLine($"{Environment.NewLine}Press any key to exit...");
            Console.WriteLine($"\nHello, {name}, on {currentDate:d} at {currentDate:t}!"); // \n can be used in place of {Environment.NewLine} for C#
            Console.WriteLine($"\nPress any key to exit..."); // \n can be used in place of {Environment.NewLine} for C#
            Console.ReadKey(true);
        }
    }
}
