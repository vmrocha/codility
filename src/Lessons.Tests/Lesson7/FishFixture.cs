using Lessons.Lesson7.Fish;
using NUnit.Framework;

namespace Lessons.Tests.Lesson7
{
    public class FishFixture
    {
        [TestCaseSource(nameof(Data))]
        public void Solution(int expected, int[] a, int[] b)
        {
            var instance = new Solution();
            Assert.AreEqual(expected, instance.solution(a, b));
        }

        private static object[] Data => new object[]
        {
            new object[] { 2, new [] { 4, 3, 2, 1, 5 }, new [] { 0, 1, 0, 0, 0 } }
        };
    }
}
