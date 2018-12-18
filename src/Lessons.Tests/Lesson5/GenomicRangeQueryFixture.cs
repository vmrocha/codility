using Lessons.Lesson5.GenomicRangeQuery;
using NUnit.Framework;

namespace Lessons.Tests.Lesson5
{
    public class GenomicRangeQueryFixture
    {
        [TestCaseSource(nameof(Data))]
        public void Solution(int[] expected, string s, int[] p, int[] q)
        {
            var instance = new Solution();
            Assert.AreEqual(expected, instance.solution(s, p, q));
        }

        private static object[] Data => new object[]
        {
            new object[]
            {
                new [] {2, 4, 1}, "CAGCCTA", new[] { 2, 5, 0 }, new[] {4, 5, 6}
            }
        };
    }
}
