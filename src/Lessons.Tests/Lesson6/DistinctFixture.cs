using Lessons.Lesson6;
using NUnit.Framework;

namespace Lessons.Tests.Lesson6
{
    internal class DistinctFixture
    {
        [TestCaseSource(nameof(Data))]
        public void Distinct(int expected, int[] a)
        {
            Assert.AreEqual(expected, new Distinct().solution(a));
        }

        private static object[] Data => new object[]
        {
            new object[] { 3, new[] { 2, 1, 1, 2, 3, 1 } },
            new object[] { 1, new[] { 0 } },
            new object[] { 1, new[] { 0, 0 } }
        };
    }
}
