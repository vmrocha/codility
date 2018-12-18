using Lessons.Lesson6.MaxProductOfThree;
using NUnit.Framework;

namespace Lessons.Tests.Lesson6
{
    public class MaxProductOfThreeFixture
    {
        [TestCaseSource(nameof(Data))]
        public void MaxProductOfThree(int expected, int[] a)
        {
            var instnace = new Solution();
            Assert.AreEqual(expected, instnace.solution(a));
        }

        private static object[] Data => new object[]
        {
            new object[] { 60, new[] { -3, 1, 2, -2, 5, 6 } }
        };
    }
}
