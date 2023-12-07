using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace Logic.Year2023;

public class Day01 : ISolvePuzzles
{
    public string GetSolution1(string calibrationValues)
    {
        var values = calibrationValues.Split(Environment.NewLine)
            .Select(GetCalibrationValue)
            .Sum();

        return values.ToString();
    }

    int GetCalibrationValue(string calibrationValue)
    {
        var pattern = @"\d";
        var value1 = Regex.Match(calibrationValue, pattern).Value;
        var value2 = Regex.Match(calibrationValue, pattern, RegexOptions.RightToLeft).Value;

        return int.Parse(value1 + value2);
    }
    
    int GetCalibrationValueDigitInLetters(string calibrationValue)
    {
        var pattern = @"\d|one|two|three|four|five|six|seven|eight|nine";
        var matchCollection = Regex.Matches(calibrationValue, pattern);

        if (matchCollection.Count == 0) return 0;

        var value1 = Regex.Match(calibrationValue, pattern).Value;
        var value2 = Regex.Match(calibrationValue, pattern, RegexOptions.RightToLeft).Value;
        
        var digit1 = ParseDigitAsLetter(value1);
        var digit2 = ParseDigitAsLetter(value2);

        return digit1 * 10 + digit2;
    }
    
    int ParseDigitAsLetter(string value)
        => value switch
        {
            "one" => 1,
            "two" => 2,
            "three" => 3,
            "four" => 4,
            "five" => 5,
            "six" => 6,
            "seven" => 7,
            "eight" => 8,
            "nine" => 9,
            _ => int.Parse(value)
        };
    
    public string GetSolution2(string calibrationValues)
    {
        var values = calibrationValues.Split(Environment.NewLine)
            .Select(GetCalibrationValueDigitInLetters)
            .Sum();

        return values.ToString();
    }
}