using Logic;
using Logic.Year2019;
using System;
using System.IO;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AdventOfCode");

            PrintSolution<Day08>();
        }
        

        static void PrintSolution<T>() where T : ISolvePuzzles
        {
            T day = Activator.CreateInstance<T>();

            var num = day.GetType().Name.Substring(3);
            var input = File.ReadAllText(@$"Input\2019-{num}.txt");

            Console.WriteLine($"Solution1: {day.GetSolution1(input)}");
            Console.WriteLine($"Solution2: {day.GetSolution2(input)}");
        }
    }
}
