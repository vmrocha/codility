using Lessons.Lesson5.PassingCars;
using NUnit.Framework;

namespace Lessons.Tests.Lesson5
{
    public class PassingCarsFixture
    {
        [TestCaseSource(nameof(Data))]
        public void Solution(int expected, int[] a)
        {
            var instance = new Solution();
            Assert.AreEqual(expected, instance.solution(a));
        }

        private static object[] Data => new object[]
        {
            new object[] {5, new[] { 0, 1, 0, 1, 1 } },
            new object[] {0, new[] { 1 } },
            new object[] {0, new[] { 1, 0 } },
            new object[] {1, new[] { 0, 1 } },
            new object[] {0, new[] { 1, 1 } },
            new object[] {0, new[] { 0, 0 } },
            new object[] {2, new[] { 0, 1, 1 } }
        };
    }
}
