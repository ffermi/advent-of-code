using Logic.Year2019;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.TestYear2019
{
    [TestClass]
    public class TestDay08 : TestBase<Day08>
    {
        [DataTestMethod]
        [DataRow("123456789012", "1")]
        public override void Solution1(string input, string expectedResult)
        {
            Assert.AreEqual(expectedResult, Day.GetSolution1(input));
        }

        public override void Solution2(string input, string expectedResult)
        {
        }
    }
}
