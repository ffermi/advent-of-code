using System;
using System.Linq;

namespace Logic.Year2019
{
    public class Day02 : ISolvePuzzles
    {
        public string GetSolution1(string calibrationValues)
        {
            int[] result;

#if RELEASE
            result = ExecuteIntcode(input, noun: 12, verb: 2);
            return result[0].ToString();
#else
            result = ExecuteIntcode(calibrationValues, noun: null, verb: null);
            return string.Join(',', result);
#endif
        }

        public string GetSolution2(string input)
        {
            const int ExpectedResult = 19690720;
            const int MaxValue = 99;

            int noun = 0;
            int verb = 0;
            int result = 0;

            for (noun = 0; noun < MaxValue; noun++)
            {
                for (verb = 0; verb < MaxValue; verb++)
                {
                    result = ExecuteIntcode(input, noun, verb)[0];
                    if (result.Equals(ExpectedResult)) break;
                }
                if (result.Equals(ExpectedResult)) break;
            }

            return $"{100 * noun + verb}";
        }


        private int[] ExecuteIntcode(string input, int? noun, int? verb)
        {
            const int InstructionPointerStep = 4;
            int[] intcode = GetIntcode(input, noun, verb);

            for (int i = 0; i < intcode.Length; i = i + InstructionPointerStep)
            {
                var opCode = (OpCode)intcode[i];

                if (opCode.Equals(OpCode.Halt)) break;

                var param = GetAddresses(intcode, i);

                intcode[param.address3] = ExecuteInstruction(opCode, intcode[param.address1], intcode[param.address2]);
            }

            return intcode;
        }

        private int[] GetIntcode(string input, int? noun = null, int? verb = null)
        {
            var intcode = input.Split(',').Select(x => int.Parse(x)).ToArray();

            if (noun.HasValue) intcode[1] = noun.Value;
            if (verb.HasValue) intcode[2] = verb.Value;

            return intcode;
        }

        private (int address1, int address2, int address3) GetAddresses(int[] intcode, int i) => (intcode[i + 1], intcode[i + 2], intcode[i + 3]);

        int ExecuteInstruction(OpCode op, int input1, int input2)
        {
            switch (op)
            {
                case OpCode.Add:
                    return input1 + input2;
                case OpCode.Multiply:
                    return input1 * input2;
                case OpCode.Halt:
                default:
                    return -1;
            }
        }
    }

    internal enum OpCode
    {
        Add = 1,
        Multiply,
        Halt = 99
    }
}
