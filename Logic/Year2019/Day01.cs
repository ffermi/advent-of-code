using System;
using System.Linq;

namespace Logic.Year2019
{
    public class Day01 : ISolvePuzzles
    {
        public string GetSolution1(string calibrationValues)
        {
            return calibrationValues
                .Split(Environment.NewLine)
                .Select(x => long.Parse(x))
                .Select(FuelRequired)
                .Sum()
                .ToString();
        }

        public string GetSolution2(string moduleMasses)
        {
            return moduleMasses
                .Split(Environment.NewLine)
                .Select(x => long.Parse(x))
                .Select(x => FuelRecursive(x, 0))
                .Sum()
                .ToString();
        }

        private long FuelRequired(long mass) => (mass / 3) - 2;

        private long FuelRecursive(long fuel, long accumulator)
        {
            var required = FuelRequired(fuel);
            return required > 0 ? FuelRecursive(required, accumulator + required) : accumulator;
        }
    }
}
