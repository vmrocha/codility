using Lessons.Lesson2.OddOccurrencesInArray;
using NUnit.Framework;

namespace Lessons.Tests.Lesson2
{
    [TestFixture]
    public class OddOccurrencesInArrayFixture
    {
        [TestCaseSource(nameof(Data))]
        public void Solution(int[] array, int expected)
        {
            var instance = new Solution();
            Assert.AreEqual(expected, instance.solution(array));
        }

        private static object[] Data => new object[]
        {
            new object[] {new[] {1, 2, 1}, 2},
            new object[] {new[] { 1, 3, 1 }, 3},
            new object[] {new[] { 1, 3, 1, 3, 1 }, 1},
            new object[] {new[] { 1, 3, 1, 3, 4 }, 4}
        };
    }
}
