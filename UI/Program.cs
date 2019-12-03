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

            var day = new Day03();
            var input = File.ReadAllText(@"Input\2019-03.txt");
            Console.WriteLine($"Solution1: {day.GetSolution1(input)}");
            Console.WriteLine($"Solution2: {day.GetSolution2(input)}");
        }
        
    }
}
