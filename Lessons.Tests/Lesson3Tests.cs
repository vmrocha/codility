using Lessons.Lesson3;
using NUnit.Framework;

namespace Lessons.Tests
{
    [TestFixture]
    public class Lesson3Tests
    {
        [TestCase]
        public void FrogJmp()
        {
            var instance = new FrogJmp();

            Assert.AreEqual(3, instance.solution(10, 85, 30));
            Assert.AreEqual(1, instance.solution(10, 40, 30));
            Assert.AreEqual(2, instance.solution(10, 70, 30));
            Assert.AreEqual(3, instance.solution(10, 71, 30));
        }

        [TestCase]
        public void PermMissingElem()
        {
            var instance = new PermMissingElem();

            Assert.AreEqual(4, instance.solution(new[] { 2, 3, 1, 5 }));
            Assert.AreEqual(2, instance.solution(new[] { 1, 3 }));
            Assert.AreEqual(2, instance.solution(new[] { 3, 1 }));
            Assert.AreEqual(1, instance.solution(new[] { 2 }));
        }
    }
}
