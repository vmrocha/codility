using Lessons.Lesson7.Nesting;
using NUnit.Framework;

namespace Lessons.Tests.Lesson7
{
    public class NestingFixture
    {
        [TestCaseSource(nameof(Data))]
        public void Solution(int expected, string s)
        {
            var instance = new Solution();
            Assert.AreEqual(expected, instance.solution(s));
        }

        private static object[] Data => new object[]
        {
            new object[] { 1, "(()(())())" },
            new object[] { 0, "())" }
        };
    }
}
