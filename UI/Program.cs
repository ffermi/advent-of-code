using Logic;
using System;
using System.IO;
using Logic.Year2023;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AdventOfCode");

            PrintSolution<Day03>();
        }
        

        static void PrintSolution<T>() where T : ISolvePuzzles
        {
            T day = Activator.CreateInstance<T>();

            var num = day.GetType().Name.Substring(3);
            var input = File.ReadAllText(@$"Input/2023-{num}.txt");

            Console.WriteLine($"Solution1: {day.GetSolution1(input)}");
            Console.WriteLine($"Solution2: {day.GetSolution2(input)}");
        }
    }
}
