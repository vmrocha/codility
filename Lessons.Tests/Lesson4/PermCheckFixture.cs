using Lessons.Lesson4;
using NUnit.Framework;

namespace Lessons.Tests.Lesson4
{
    [TestFixture]
    public class PermCheckFixture
    {
        [TestCaseSource(nameof(Data))]
        public void PermCheck(int expected, int[] A)
        {
            Assert.AreEqual(expected, new PermCheck().solution(A));
        }

        private static object[] Data => new object[]
        {
            new object[] {1, new[] { 2, 3, 1 } },
            new object[] {0, new[] { 2, 4, 1 } }
        };
    }
}
