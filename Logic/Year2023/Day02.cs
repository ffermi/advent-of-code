using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace Logic.Year2023;

public class Day02 : ISolvePuzzles
{
    private IReadOnlyDictionary<string, int> Reference => new Dictionary<string, int>
    {
        { "red", 12 },
        { "green", 13 },
        { "blue", 14 }
    };
    
    public string GetSolution1(string input)
    {
        var values = input.Split(Environment.NewLine)
            .Select(EvaluateGame1)
            .Sum();
        
        return values.ToString();
    }

    int EvaluateGame1(string gameExtractions)
    {
        var matchGame = Regex.Match(gameExtractions, @"^Game (\d+):");
        var gameNumber = int.Parse(matchGame.Groups[1].Value);
        
        var matchExtractions  = Regex.Matches(gameExtractions, @"(\d+) (red|green|blue)");

        foreach (Match extraction in matchExtractions)
        {
            var cubes = int.Parse(extraction.Groups[1].Value);
            var color = extraction.Groups[2].Value;

            if (Reference[color] < cubes)
                return 0;
        }
        
        return gameNumber;
    }
    int EvaluateGame2(string gameExtractions)
    {
        var matchExtractions  = Regex.Matches(gameExtractions, @"(\d+) (red|green|blue)");

        var gameResult = new Dictionary<string, int>
        {
            { "red", 1 },
            { "green", 1 },
            { "blue", 1 }
        };
        
        foreach (Match extraction in matchExtractions)
        {
            var cubes = int.Parse(extraction.Groups[1].Value);
            var color = extraction.Groups[2].Value;

            if (gameResult[color] < cubes)
                gameResult[color] = cubes;
        }

        return gameResult.Select(x => x.Value).Aggregate((c, n) => c * n);
    }
    
    public string GetSolution2(string input)
    {
        var values = input.Split(Environment.NewLine)
            .Select(EvaluateGame2)
            .Sum();
        
        return values.ToString();
    }
    
}