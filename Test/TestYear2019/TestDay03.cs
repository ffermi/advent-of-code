using Logic.Year2019;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.TestYear2019
{
    [TestClass]
    public class TestDay03 : TestBase<Day03>
    {
        [DataTestMethod]
        [DataRow("R8,U5,L5,D3\nU7,R6,D4,L4", "6")]
        [DataRow("R75,D30,R83,U83,L12,D49,R71,U7,L72\nU62,R66,U55,R34,D71,R55,D58,R83", "146")]
        [DataRow("R98,U47,R26,D63,R33,U87,L62,D20,R33,U53,R51\nU98,R91,D20,R16,D67,R40,U7,R15,U6,R7", "135")]
        public override void Solution1(string input, string expectedResult)
        {
            Assert.AreEqual(expectedResult, Day.GetSolution1(input));
        }

        [DataTestMethod]
        [DataRow("R8,U5,L5,D3\nU7,R6,D4,L4", "30")]
        [DataRow("R75,D30,R83,U83,L12,D49,R71,U7,L72\nU62,R66,U55,R34,D71,R55,D58,R83", "610")]
        [DataRow("R98,U47,R26,D63,R33,U87,L62,D20,R33,U53,R51\nU98,R91,D20,R16,D67,R40,U7,R15,U6,R7", "410")]
        public override void Solution2(string input, string expectedResult)
        {
            Assert.AreEqual(expectedResult, Day.GetSolution2(input));
        }
    }
}
