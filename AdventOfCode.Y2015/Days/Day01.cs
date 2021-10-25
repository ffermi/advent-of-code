using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Y2015.Days
{
    public class Day01
    {
        // Literals
        private const char Up = '(';
        private const char Down = ')';

        private const int Basement = -1;

        public int GetPart01Solution(string input)
        {
            return input.Aggregate(seed: 0, func: EvaluateCharInput);
        }

        private int EvaluateCharInput(int seed, char input)
            => input.Equals(Up) ? seed + 1 : seed - 1;

        public int GetPart02Solution(string input)
        {
            int currentFloor = 0;
            int position;

            for (position = 0; position < input.Length; position++)
            {
                var charInput = input[position];
                currentFloor = EvaluateCharInput(currentFloor, charInput);
                if (currentFloor == Basement)
                    break;
            }

            return ++position;
        }
    }
}

