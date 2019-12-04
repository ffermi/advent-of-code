using Logic.Year2019;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.TestYear2019
{
    [TestClass]
    public class TestDay04 : TestBase<Day04>
    {
        [DataTestMethod]
        [DataRow("111111-111111", "1")]
        [DataRow("223450-223450", "0")]
        [DataRow("123789-123789", "0")]
        public override void Solution1(string input, string expectedResult)
        {
            Assert.AreEqual(expectedResult, Day.GetSolution1(input));
        }

        [DataTestMethod]
        [DataRow("112233-112233", "1")]
        [DataRow("123444-123444", "0")]
        [DataRow("111122-111122", "1")]
        public override void Solution2(string input, string expectedResult)
        {
            Assert.AreEqual(expectedResult, Day.GetSolution2(input));
        }
    }
}
