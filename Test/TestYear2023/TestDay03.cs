using Logic.Year2023;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.TestYear2023;

[TestClass]
public class TestDay03 : TestBase<Day03>
{
    //12 red cubes, 13 green cubes, and 14 blue cubes
    
    [DataTestMethod]
    [DataRow("467..114..\n...*......\n..35..633.\n......#...\n617*......\n.....+.58.\n..592.....\n......755.\n...$.*....\n.664.598..", "4361")]
    public override void Solution1(string input, string expectedResult)
    {
        Assert.AreEqual(expectedResult, Day.GetSolution1(input));
    }

    [DataTestMethod]
    [DataRow("467..114..\n...*......\n..35..633.\n......#...\n617*......\n.....+.58.\n..592.....\n......755.\n...$.*....\n.664.598..", "467835")]
    public override void Solution2(string input, string expectedResult)
    {
        Assert.AreEqual(expectedResult, Day.GetSolution2(input));
    }
}

