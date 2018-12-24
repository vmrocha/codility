using Lessons.Lesson7.StoneWall;
using NUnit.Framework;

namespace Lessons.Tests.Lesson7
{
    public class StoneWallFixture
    {
        [TestCaseSource(nameof(Data))]
        public void Solution(int expected, int[] h)
        {
            var instance = new Solution();
            Assert.AreEqual(expected, instance.solution(h));
        }

        private static object[] Data => new object[]
        {
            new object[] { 7, new [] { 8, 8, 5, 7, 9, 8, 7, 4, 8 } }
        };
    }
}
