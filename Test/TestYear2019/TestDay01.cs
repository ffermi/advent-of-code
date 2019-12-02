using Logic.Year2019;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.TestYear2019
{
    [TestClass]
    public class TestDay01 : TestBase<Day01>
    {
        [DataTestMethod]
        [DataRow("12", "2")]
        [DataRow("14", "2")]
        [DataRow("1969", "654")]
        [DataRow("100756", "33583")]
        public override void Solution1(string input, string expectedResult)
        {
            Assert.AreEqual(expectedResult, Day.GetSolution1(input));
        }

        [DataTestMethod]
        [DataRow("12", "2")]
        [DataRow("14", "2")]
        [DataRow("1969", "966")]
        [DataRow("100756", "50346")]
        public override void Solution2(string input, string expectedResult)
        {
            Assert.AreEqual(expectedResult, Day.GetSolution2(input));
        }
    }
}
