using Lessons.Lesson5;
using NUnit.Framework;

namespace Lessons.Tests.Lesson5
{
    public class GenomicRangeQueryFixture
    {
        [TestCaseSource(nameof(Data))]
        public void GenomicRangeQuery(int[] expected, string s, int[] p, int[] q)
        {
            Assert.AreEqual(expected, new GenomicRangeQuery().solution(s, p, q));
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
