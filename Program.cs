using System;

namespace Intro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! I'm glad to meet you.");
            Console.WriteLine($"How are you doing today, {name}?");
            string mood = Console.ReadLine();
            Console.WriteLine($"{mood}? Your day can only get better from hear!");
        }
    }
}