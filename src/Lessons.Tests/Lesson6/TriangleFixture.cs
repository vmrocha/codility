using Lessons.Lesson6.Triangle;
using NUnit.Framework;

namespace Lessons.Tests.Lesson6
{
    public class TriangleFixture
    {
        [TestCaseSource(nameof(Data))]
        public void Solution(int expected, int[] a)
        {
            var instance = new Solution();
            Assert.AreEqual(expected, instance.solution(a));
        }

        private static object[] Data => new object[]
        {
            new object[] { 1, new[] { 10, 2, 5, 1, 8, 20 } },
            new object[] { 0, new[] { 10, 50, 5, 1 } },
            new object[] { 1, new[] { int.MaxValue, int.MaxValue, int.MaxValue } }
        };
    }
}
