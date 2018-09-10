using Lessons.Lesson2;
using NUnit.Framework;

namespace Lessons.Tests
{
    [TestFixture]
    public class Lesson2Tests
    {
        [TestCase]
        public void CyclicRotationTests()
        {
            var instance = new CyclicRotation();

            Assert.AreEqual(instance.solution(new int[0], 1), new int[0]);

            Assert.AreEqual(new[] { 1 }, instance.solution(new[] { 1 }, 1));
            Assert.AreEqual(new[] { 1 }, instance.solution(new[] { 1 }, 2));
            Assert.AreEqual(new[] { 1 }, instance.solution(new[] { 1 }, 3));

            Assert.AreEqual(new[] { 2, 1 }, instance.solution(new[] { 1, 2 }, 1));
            Assert.AreEqual(new[] { 1, 2 }, instance.solution(new[] { 1, 2 }, 2));
            Assert.AreEqual(new[] { 2, 1 }, instance.solution(new[] { 1, 2 }, 3));

            Assert.AreEqual(new[] { 3, 1, 2 }, instance.solution(new[] { 1, 2, 3 }, 1));
            Assert.AreEqual(new[] { 2, 3, 1 }, instance.solution(new[] { 1, 2, 3 }, 2));
            Assert.AreEqual(new[] { 1, 2, 3 }, instance.solution(new[] { 1, 2, 3 }, 3));
            Assert.AreEqual(new[] { 3, 1, 2 }, instance.solution(new[] { 1, 2, 3 }, 4));
        }

        [TestCase]
        public void OddOccurrencesInArray()
        {
            var instance = new OddOccurrencesInArray();

            Assert.AreEqual(2, instance.solution(new[] { 1, 2, 1 }));
            Assert.AreEqual(3, instance.solution(new[] { 1, 3, 1 }));
            Assert.AreEqual(1, instance.solution(new[] { 1, 3, 1, 3, 1 }));
            Assert.AreEqual(4, instance.solution(new[] { 1, 3, 1, 3, 4 }));
        }
    }
}
