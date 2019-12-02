using System;
using System.Linq;

namespace Logic.Year2019
{
    public class Day02 : ISolvePuzzles
    {
        public string GetSolution1(string input)
        {
            int[] instructions = input.Split(',').Select(x => int.Parse(x)).ToArray();

#if  RELEASE
            instructions[1] = 12;
            instructions[2] = 2;
#endif

            for (int i = 0; i < instructions.Length; i = i + 4)
            {
                var op = (OpCode)instructions[i];
                
                if (op.Equals(OpCode.Halt)) break;

                var data = GetRefData(instructions, i);
                instructions[data.refResult] = GetResult(op, instructions[data.ref1], instructions[data.ref2]);
            }

            return string.Join(',', instructions);

            (int ref1, int ref2, int refResult) GetRefData(int[] input, int i) => (instructions[i + 1], instructions[i + 2], instructions[i + 3]);

            int GetResult(OpCode op, int a, int b)
            {
                switch (op)
                {
                    case OpCode.Add:
                        return a + b;    
                    case OpCode.Multiply:
                        return a * b;
                    case OpCode.Halt:
                    default:
                        return -1;
                }
            }
        }

        public string GetSolution2(string input)
        {
            throw new NotImplementedException();
        }
    }

    internal enum OpCode
    {
        Add = 1,
        Multiply = 2,
        Halt = 99
    }
}
