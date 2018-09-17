using Lessons.Lesson4;
using NUnit.Framework;

namespace Lessons.Tests.Lesson4
{
    [TestFixture]
    public class MaxCountersFixture
    {
        [TestCaseSource(nameof(Data))]
        public void Solution(int[] expected, int N, int[] A)
        {
            Assert.AreEqual(expected, new MaxCounters().Solution(N, A));
        }

        private static object[] Data => new object[]
        {
            new object[] { new[] { 3, 2, 2, 4, 2 }, 5, new[] { 3, 4, 4, 6, 1, 4, 4 } }
        };
    }
}
