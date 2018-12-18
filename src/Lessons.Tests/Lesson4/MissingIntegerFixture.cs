using Lessons.Lesson4.MissingInteger;
using NUnit.Framework;

namespace Lessons.Tests.Lesson4
{
    [TestFixture]
    public class MissingIntegerFixture
    {
        [TestCaseSource(nameof(Data))]
        public void Solution(int expected, int[] a)
        {
            var instance = new Solution();
            Assert.AreEqual(expected, instance.solution(a));
        }

        private static object[] Data => new object[]
        {
            new object[] {5, new [] { 1, 3, 6, 4, 1, 2 }},
            new object[] {4, new [] { 1, 2, 3 }},
            new object[] {1, new [] { -1, -2 }},
            new object[] {1, new [] { 2 }}
        };
    }
}
