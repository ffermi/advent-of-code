using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace Logic.Year2023;

public class Day03 : ISolvePuzzles
{
    private const string MatchNumber = @"\d+";
    private const string MatchSymbols = @"[^.0-9]";
    private const string MatchGear = @"\*";

    public string GetSolution1(string input)
    {
        var inputArray = input.Split(Environment.NewLine);

        var values = inputArray.Select((x, i) =>
        {
            var rowPartNumberSum = 0;
            var previous = i == 0 ? string.Empty : inputArray[i - 1];
            var next = i == inputArray.Length - 1 ? string.Empty : inputArray[i + 1];

            var matchNumbers = Regex.Matches(x, MatchNumber);
            var prevMatchSymbols = Regex.Matches(previous, MatchSymbols);
            var currentMatchSymbols = Regex.Matches(x, MatchSymbols);
            var nextMatchSymbols = Regex.Matches(next, MatchSymbols);

            foreach (Match number in matchNumbers)
            {
                if (GetAdjacentSymbols(number, prevMatchSymbols, currentMatchSymbols, nextMatchSymbols).Length > 0)
                    rowPartNumberSum += int.Parse(number.Value);
            }

            return rowPartNumberSum;
        }).Sum();

        return values.ToString();
    }

    Match[] GetAdjacentSymbols(Match targetSymbol, MatchCollection prevSymbols, MatchCollection currentSymbols,
        MatchCollection nextSymbols)
    {
        var previous = prevSymbols.Where(x =>
            GetEndIndex(x) >= targetSymbol.Index - 1 && x.Index <= targetSymbol.Index + targetSymbol.Length);
        var current = currentSymbols.Where(x =>
            GetEndIndex(x) >= targetSymbol.Index - 1 && x.Index<= targetSymbol.Index + targetSymbol.Length);
        var next = nextSymbols.Where(x =>
            GetEndIndex(x) >= targetSymbol.Index - 1 && x.Index <= targetSymbol.Index + targetSymbol.Length);

        return previous.Concat(current).Concat(next).ToArray();

        int GetEndIndex(Match symbol) => symbol.Index + symbol.Length - 1;
    }

    public string GetSolution2(string input)
    {
        var inputArray = input.Split(Environment.NewLine);
        var values = inputArray.Select((x, i) =>
        {
            var gearNumberSum = 0;
            var previous = i == 0 ? string.Empty : inputArray[i - 1];
            var next = i == inputArray.Length - 1 ? string.Empty : inputArray[i + 1];

            var matchGear = Regex.Matches(x, MatchGear);
            var prevMatchNumbers = Regex.Matches(previous, MatchNumber);
            var currentMatchNumbers = Regex.Matches(x, MatchNumber);
            var nextMatchNumbers = Regex.Matches(next, MatchNumber);

            foreach (Match gear in matchGear)
            {
                var gearNumbers = GetAdjacentSymbols(gear, prevMatchNumbers, currentMatchNumbers, nextMatchNumbers);
                if (gearNumbers.Length == 2)
                    gearNumberSum += int.Parse(gearNumbers[0].Value) * int.Parse(gearNumbers[1].Value);
            }

            return gearNumberSum;
        }).Sum();
        return values.ToString();
    }
}