using Lessons.Lesson3.PermMissingElem;
using NUnit.Framework;

namespace Lessons.Tests.Lesson3
{
    [TestFixture]
    public class PermMissingElemFixture
    {
        [TestCaseSource(nameof(Data))]
        public void Solution(int[] a, int expected)
        {
            var instance = new Solution();
            Assert.AreEqual(expected, instance.solution(a));
        }

        private static object[] Data => new object[]
        {
            new object[] {new[] { 2, 3, 1, 5 }, 4},
            new object[] {new[] { 1, 3 }, 2},
            new object[] {new[] { 3, 1 }, 2},
            new object[] {new[] { 2 }, 1}
        };
    }
}
