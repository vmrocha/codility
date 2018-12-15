using Lessons.Lesson5;
using NUnit.Framework;

namespace Lessons.Tests.Lesson5
{
    public class MinAvgTwoSliceFixture
    {
        [TestCaseSource(nameof(Data))]
        public void MinAvgTwoSlice(int expected, int[] a)
        {
            Assert.AreEqual(expected, new MinAvgTwoSlice().solution(a));
        }

        private static object[] Data => new object[]
        {
            new object[] { 1, new[] { 4, 2, 2, 5, 1, 5, 8 } }
        };
    }
}
