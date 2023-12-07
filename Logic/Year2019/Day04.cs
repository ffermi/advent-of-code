using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic.Year2019
{
    public class Day04 : ISolvePuzzles
    {
        public string GetSolution1(string calibrationValues)
        {
            var boundaries = calibrationValues.Split('-');
            int min = int.Parse(boundaries[0]);
            int max = int.Parse(boundaries[1]);

            int count = 0;
            for (int i = min; i <= max; i++)
            {
                string n = i.ToString();

                var allIncrement = n.Select((x, i) => i == 0 || x >= n[i - 1]).All(x => x);
                var twoAdjacentDigitsAreTheSame = n.Select(x => n.Count(y => y == x)).Distinct().Any(x => x > 1);

                if (allIncrement && twoAdjacentDigitsAreTheSame) count++;
            }

            return count.ToString();
        }

        public string GetSolution2(string input)
        {
            var boundaries = input.Split('-');
            int min = int.Parse(boundaries[0]);
            int max = int.Parse(boundaries[1]);

            int count = 0;

            for (int i = min; i <= max; i++)
            {
                string n = i.ToString();

                var allIncrement = n.Select((x, i) => i == 0 || x >= n[i - 1]).All(x => x);
                var cannotBePartOfLargerGroup = n.Select(x => n.Count(y => y == x)).Distinct().Any(x => x == 2);

                if (allIncrement && cannotBePartOfLargerGroup) count++;
            }

            return count.ToString();
        }

    }
}
