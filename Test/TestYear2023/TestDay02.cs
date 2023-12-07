using Logic.Year2023;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.TestYear2023;

[TestClass]
public class TestDay02 : TestBase<Day02>
{
    //12 red cubes, 13 green cubes, and 14 blue cubes
    
    [DataTestMethod]
    [DataRow("Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green", "1")]
    [DataRow("Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue","2")]
    [DataRow("Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red","0")] 
    [DataRow("Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red","0")] 
    [DataRow("Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green","5")]
    public override void Solution1(string input, string expectedResult)
    {
        Assert.AreEqual(expectedResult, Day.GetSolution1(input));
    }

    [DataTestMethod]
    [DataRow("Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green", "48")]
    [DataRow("Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue","12")]
    [DataRow("Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red","1560")] 
    [DataRow("Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red","630")] 
    [DataRow("Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green","36")]
    public override void Solution2(string input, string expectedResult)
    {
        Assert.AreEqual(expectedResult, Day.GetSolution2(input));
    }
}

