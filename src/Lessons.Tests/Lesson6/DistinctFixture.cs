using Lessons.Lesson6.Distinct;
using NUnit.Framework;

namespace Lessons.Tests.Lesson6
{
    public class DistinctFixture
    {
        [TestCaseSource(nameof(Data))]
        public void Solution(int expected, int[] a)
        {
            var instance = new Solution();
            Assert.AreEqual(expected, instance.solution(a));
        }

        private static object[] Data => new object[]
        {
            new object[] { 3, new[] { 2, 1, 1, 2, 3, 1 } },
            new object[] { 1, new[] { 0 } },
            new object[] { 1, new[] { 0, 0 } }
        };
    }
}
