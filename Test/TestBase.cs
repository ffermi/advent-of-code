using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public abstract class TestBase<T> where T : ISolvePuzzles
    {
        protected T Day { get; private set; }

        [TestInitialize]
        public void Initialize() => Day = Day ?? Activator.CreateInstance<T>();

        public abstract void Solution1(string input, string expectedResult);

        public abstract void Solution2(string input, string expectedResult);
    }
}
