// See https://aka.ms/new-console-template for more information
using AdventOfCode.Y2015.Days;

Console.WriteLine("AdventOfCode");


var day01 = new Day01();
var input01 = Utils.GetInput(1);
Console.WriteLine($"Day 01: {day01.GetPart01Solution(input01)}, {day01.GetPart02Solution(input01)}");

var day02 = new Day02();
var input02 = Utils.GetInput(2);
Console.WriteLine($"Day 02: {day02.GetPart01Solution(input02)}, {day02.GetPart02Solution(input02)}");


internal static class Utils {
    public static string GetInput(int day) => File.ReadAllText(@$"Inputs\2015-{day:D2}.txt");
}