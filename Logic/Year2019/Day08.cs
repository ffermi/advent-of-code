using System;
using System.Linq;
using System.Text;

namespace Logic.Year2019
{
    public class Day08 : ISolvePuzzles
    {
#if RELEASE
        int width = 25;
        int height = 6;
#else
        int width = 3;
        int height = 2;
#endif

        public string GetSolution1(string input)
        {
            int layerLength = width * height;

            string min = string.Empty;
            for (int i = 0; i < input.Length; i += layerLength)
            {
                var s = input.Substring(i, layerLength);
                if (string.IsNullOrEmpty(min) || min.Count(x => x.Equals('0')) > s.Count(x => x.Equals('0'))) 
                    min = s;
            }

            int checksum = min.Count(x => x.Equals('1')) * min.Count(x => x.Equals('2'));

            return checksum.ToString();
        }

        public string GetSolution2(string input)
        {
            int layerLength = width * height;

            int i = 0;
            char[] bits = Enumerable.Repeat('2', layerLength).ToArray();

            while (i < input.Length && bits.Contains('2'))
            {
                var image2 = input.Substring(i, layerLength).ToCharArray();
                bits = bits.Zip(image2).Select(bit => bit.First.Equals('2') ? bit.Second : bit.First).ToArray();
                i += layerLength;
            }

            var img = new string(bits).Replace('0', ' ').Replace('1', '█');
            var sb = new StringBuilder("\n");

            for (i = 0; i < height; i++) sb.AppendLine(img.Substring(i * width, width));

            return sb.ToString();
        }


    }
}
