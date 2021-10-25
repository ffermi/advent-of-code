using AdventOfCode.Y2015.Days;
using Xunit;

namespace AdventOfCode._2015.Test
{
    public class TestDay02
    {
        readonly Day02 day02 = new Day02();

        [Theory]
        [InlineData("2x3x4", 58)]
        [InlineData("1x1x10", 43)]
        public void TestPart01(string input, int expected)
        {
            var actual = day02.GetPart01Solution(input);
            
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("2x3x4", 34)]
        [InlineData("1x1x10", 14)]
        public void TestPart02(string input, int expected)
        {
            var actual = day02.GetPart02Solution(input);

            Assert.Equal(expected, actual);
        }
    }
}