using Lessons.Lesson4;
using NUnit.Framework;

namespace Lessons.Tests.Lesson4
{
    [TestFixture]
    public class FrogJumpOneFixture
    {
        [TestCaseSource(nameof(Data))]
        public void FrogJumpOne(int expected, int X, int[] A)
        {
            Assert.AreEqual(expected, new FrogJumpOne().solution(X, A));
        }

        private static object[] Data => new object[]
        {
            new object[] { 6, 5, new [] { 1, 3, 1, 4, 2, 3, 5, 4 } },
            new object[] { 6, 5, new [] { 1, 3, 7, 4, 2, 3, 5, 4 } },
            new object[] { -1, 5, new [] { 1, 3, 7, 4, 2, 3, 2, 4 } }
        };
    }
}
