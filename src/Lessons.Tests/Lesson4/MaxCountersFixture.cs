using Lessons.Lesson4.MaxCounters;
using NUnit.Framework;

namespace Lessons.Tests.Lesson4
{
    [TestFixture]
    public class MaxCountersFixture
    {
        [TestCaseSource(nameof(Data))]
        public void Solution(int[] expected, int n, int[] a)
        {
            var instance = new Solution();
            Assert.AreEqual(expected, instance.solution(n, a));
        }

        private static object[] Data => new object[]
        {
            new object[] { new[] { 3, 2, 2, 4, 2 }, 5, new[] { 3, 4, 4, 6, 1, 4, 4 } },
            new object[] { new[] { 5, 3 }, 2, new[] { 1, 3, 2, 2, 3, 1, 1 } }
        };
    }
}
