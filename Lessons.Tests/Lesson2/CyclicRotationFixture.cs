using Lessons.Lesson2;
using NUnit.Framework;

namespace Lessons.Tests.Lesson2
{
    [TestFixture]
    public class CyclicRotationFixture
    {
        [TestCaseSource(nameof(Data))]
        public void CyclicRotationTests(int[] array, int n, int[] expected)
        {
            var instance = new CyclicRotation();
            Assert.AreEqual(instance.solution(array, n), expected);
        }

        private static object[] Data => new object[]
        {
            new object[] { new[] { 1 }, 1, new[] { 1 }},
            new object[] { new[] { 1 }, 2, new[] { 1 }},
            new object[] { new[] { 1 }, 3, new[] { 1 }},
            new object[] { new[] { 1, 2 }, 1, new[] { 2, 1 }},
            new object[] { new[] { 1, 2 }, 2, new[] { 1, 2 }},
            new object[] { new[] { 1, 2 }, 3, new[] { 2, 1 }},
            new object[] { new[] { 1, 2, 3 }, 1, new[] { 3, 1, 2 } },
            new object[] { new[] { 1, 2, 3 }, 2, new[] { 2, 3, 1 } },
            new object[] { new[] { 1, 2, 3 }, 3, new[] { 1, 2, 3 }},
            new object[] { new[] { 1, 2, 3 }, 4, new[] { 3, 1, 2 }}
        };
    }
}
