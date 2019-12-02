using Logic.Year2019;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.TestYear2019
{
    [TestClass]
    public class TestDay02 : TestBase<Day02>
    {
        [DataTestMethod]
        [DataRow("1,0,0,0,99", "2,0,0,0,99")]
        [DataRow("2,3,0,3,99", "2,3,0,6,99")]
        [DataRow("2,4,4,5,99,0", "2,4,4,5,99,9801")]
        [DataRow("1,1,1,4,99,5,6,0,99", "30,1,1,4,2,5,6,0,99")]
        public override void Solution1(string input, string expectedResult)
        {
            Assert.AreEqual(expectedResult, Day.GetSolution1(input));
        }

        public override void Solution2(string input, string expectedResult)
        {
            Assert.AreEqual(expectedResult, Day.GetSolution2(input));
        }
    }
}
