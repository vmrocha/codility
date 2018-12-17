using Lessons.Lesson6;
using NUnit.Framework;

namespace Lessons.Tests.Lesson6
{
    public class TriangleFixture
    {
        [TestCaseSource(nameof(Data))]
        public void PassingCars(int expected, int[] a)
        {
            Assert.AreEqual(expected, new Triangle().solution(a));
        }

        private static object[] Data => new object[]
        {
            new object[] { 1, new[] { 10, 2, 5, 1, 8, 20 } },
            new object[] { 0, new[] { 10, 50, 5, 1 } },
            new object[] { 0, new[] { int.MaxValue, int.MaxValue, int.MaxValue } }
        };
    }
}
