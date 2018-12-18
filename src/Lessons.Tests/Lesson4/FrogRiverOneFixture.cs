using Lessons.Lesson4.FrogRiverOne;
using NUnit.Framework;

namespace Lessons.Tests.Lesson4
{
    [TestFixture]
    public class FrogRiverOneFixture
    {
        [TestCaseSource(nameof(Data))]
        public void Solution(int expected, int x, int[] a)
        {
            var instance = new Solution();
            Assert.AreEqual(expected, instance.solution(x, a));
        }

        private static object[] Data => new object[]
        {
            new object[] { 6, 5, new [] { 1, 3, 1, 4, 2, 3, 5, 4 } },
            new object[] { 6, 5, new [] { 1, 3, 7, 4, 2, 3, 5, 4 } },
            new object[] { -1, 5, new [] { 1, 3, 7, 4, 2, 3, 2, 4 } }
        };
    }
}
