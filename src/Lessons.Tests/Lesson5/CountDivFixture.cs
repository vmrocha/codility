using Lessons.Lesson5;
using NUnit.Framework;

namespace Lessons.Tests.Lesson5
{
    public class CountDivFixture
    {
        [TestCaseSource(nameof(Data))]
        public void MinAvgTwoSlice(int expected, int a, int b, int k)
        {
            Assert.AreEqual(expected, new CountDiv().solution(a, b, k));
        }

        private static object[] Data => new object[]
        {
            new object[] { 3, 6, 11, 2 },
            new object[] { 1, 1, 1, 1 },
            new object[] { 0, 1, 5, 6 },
            new object[] { 1, 0, 0, 11 }
        };
    }
}
