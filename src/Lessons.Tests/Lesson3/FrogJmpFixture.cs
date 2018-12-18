using Lessons.Lesson3.FrogJmp;
using NUnit.Framework;

namespace Lessons.Tests.Lesson3
{
    [TestFixture]
    public class FrogJmpFixture
    {
        [TestCaseSource(nameof(Data))]
        public void Solution(int x, int y, int d, int expected)
        {
            var instance = new Solution();
            Assert.AreEqual(expected, instance.solution(x, y, d));
        }

        private static object[] Data => new object[]
        {
            new object[] { 10, 85, 30, 3 },
            new object[] { 10, 40, 30, 1 },
            new object[] { 10, 70, 30, 2 },
            new object[] { 10, 71, 30, 3 }
        };
    }
}
