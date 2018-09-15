using Lessons.Lesson3;
using NUnit.Framework;

namespace Lessons.Tests.Lesson3
{
    [TestFixture]
    public class TapeEquilibriumFixture
    {
        [TestCaseSource(nameof(Data))]
        public void TapeEquilibrium(int[] A, int expected)
        {
            var instance = new TapeEquilibrium();
            Assert.AreEqual(expected, instance.solution(A));
        }

        private static object[] Data => new object[]
        {
            new object[] { new[] { 3, 1, 2, 4, 3 }, 1 },
            new object[] { new[] { 3, 1 }, 2 },
            new object[] { new[] { 1, 3 }, 2 },
            new object[] { new[] { 1, 1 }, 0 },
            new object[] { new[] { 0, 1000 }, 1000 },
            new object[] { new[] { 1000, 0 }, 1000 },
            new object[] { new[] { 1000, 0, 1 }, 999 }
        };
    }
}
