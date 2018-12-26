using Lessons.Lesson8.EquiLeader;
using NUnit.Framework;

namespace Lessons.Tests.Lesson8
{
    public class EquiLeaderFixture
    {
        [TestCaseSource(nameof(Data))]
        public void Solution(int expected, int[] a)
        {
            var instance = new Solution();
            Assert.AreEqual(expected, instance.solution(a));
        }

        private static object[] Data => new object[]
        {
            new object[] { 2, new[] { 4, 3, 4, 4, 4, 2 } }
        };
    }
}
