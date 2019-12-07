using Logic.Year2019;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.TestYear2019
{
    [TestClass]
    public class TestDay06 : TestBase<Day06>
    {
        [DataTestMethod]
        [DataRow("COM)B\r\nB)C\r\nC)D\r\nD)E\r\nE)F\r\nB)G\r\nG)H\r\nD)I\r\nE)J\r\nJ)K\r\nK)L", "42")]
        public override void Solution1(string input, string expectedResult)
        {
            Assert.AreEqual(expectedResult, Day.GetSolution1(input));
        }

        [DataTestMethod]
        [DataRow("COM)B\r\nB)C\r\nC)D\r\nD)E\r\nE)F\r\nB)G\r\nG)H\r\nD)I\r\nE)J\r\nJ)K\r\nK)L\r\nK)YOU\r\nI)SAN", "4")]
        public override void Solution2(string input, string expectedResult)
        {
            Assert.AreEqual(expectedResult, Day.GetSolution2(input));
        }
    }
}
