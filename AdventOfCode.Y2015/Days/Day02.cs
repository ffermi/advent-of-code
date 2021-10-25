using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Y2015.Days
{
    public class Day02
    {
        //Area = 2*l*w + 2*w*h + 2*h*l + little extra paper for each present: the area of the smallest side.

        char DimensionSeparator = 'x';

        public int GetPart01Solution(string input)
        {
            return input
                .Split(Environment.NewLine)
                .Aggregate(seed: 0, func: EvaluateWrappingPaper);
        }

        private int EvaluateWrappingPaper(int seed, string presentDimensions)
        {
            (int l, int w, int h) = ParseDimensions(presentDimensions);
            (int lw, int wh, int hl) = (l * w, w * h, h * l);

            var totalArea = 2 * lw + 2 * wh + 2 * hl;
            var minDimension = Math.Min(Math.Min(lw, wh), hl);

            return seed + totalArea + minDimension;
        }

        private (int l, int w, int h) ParseDimensions(string presentDimensions)
        {
            var dimensions = presentDimensions
                .Split(DimensionSeparator)
                .Select(d => int.Parse(d))
                .ToArray();

            return (dimensions[0], dimensions[1], dimensions[2]);
        }

        public int GetPart02Solution(string input)
        {
            return input
                .Split(Environment.NewLine)
                .Aggregate(seed: 0, func: EvaluateRibbon);
        }

        private int EvaluateRibbon(int seed, string presentDimensions)
        {
            (int l, int w, int h) = ParseDimensions(presentDimensions);
            var secondMinSize = Math.Min(l, w);
            var minSize = Math.Min(h, Math.Max(l, w));
            
            var ribbon = 2 * secondMinSize + 2 * minSize;
            
            var bow = l * w * h;

            return seed + ribbon + bow;
        }
    }
}

