using AdventOfCode.Y2015.Days;
using Xunit;

namespace AdventOfCode._2015.Test
{
    public class TestDay01
    {
        readonly Day01 day01 = new Day01();

        [Theory]
        [InlineData("(())", 0)]
        [InlineData("()()", 0)]
        [InlineData("(((", 3)]
        [InlineData("(()(()(", 3)]
        [InlineData("))(((((", 3)]
        [InlineData("())", -1)]
        [InlineData("))(", -1)]
        [InlineData(")))", -3)]
        [InlineData(")())())", -3)]
        public void TestPart01(string input, int expectedFloor)
        {
            var floor = day01.GetPart01Solution(input);
            
            Assert.Equal(expectedFloor, floor);
        }

        [Theory]
        [InlineData(")", 1)]
        [InlineData("()())", 5)]
        public void TestPart02(string input, int expectedPosition)
        {
            var position = day01.GetPart02Solution(input);

            Assert.Equal(expectedPosition, position);
        }
    }
}