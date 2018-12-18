using Lessons.Lesson5.MinAvgTwoSlice;
using NUnit.Framework;

namespace Lessons.Tests.Lesson5
{
    public class MinAvgTwoSliceFixture
    {
        [TestCaseSource(nameof(Data))]
        public void Solution(int expected, int[] a)
        {
            var instance = new Solution();
            Assert.AreEqual(expected, instance.solution(a));
        }

        private static object[] Data => new object[]
        {
            new object[] { 1, new[] { 4, 2, 2, 5, 1, 5, 8 } }
        };
    }
}
