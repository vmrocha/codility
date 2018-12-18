using Lessons.Lesson4.PermCheck;
using NUnit.Framework;

namespace Lessons.Tests.Lesson4
{
    [TestFixture]
    public class PermCheckFixture
    {
        [TestCaseSource(nameof(Data))]
        public void Solution(int expected, int[] a)
        {
            var instance = new Solution();
            Assert.AreEqual(expected, instance.solution(a));
        }

        private static object[] Data => new object[]
        {
            new object[] {1, new[] { 2, 3, 1 } },
            new object[] {0, new[] { 2, 4, 1 } }
        };
    }
}
