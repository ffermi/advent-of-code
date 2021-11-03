// See https://aka.ms/new-console-template for more information
using AdventOfCode.Common;
using AdventOfCode.Y2015;
using AdventOfCode.Y2015.Days;

Console.WriteLine("AdventOfCode 2015");

var input = new InputManager(2015);

var day01 = new Day01();
var input01 = input.GetInputDay(1);
Console.WriteLine($"Day 01: {day01.GetPart01Solution(input01)}, {day01.GetPart02Solution(input01)}");

var day02 = new Day02();
var input02 = input.GetInputDay(2);
Console.WriteLine($"Day 02: {day02.GetPart01Solution(input02)}, {day02.GetPart02Solution(input02)}");
