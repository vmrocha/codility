using Lessons.Lesson4;
using NUnit.Framework;

namespace Lessons.Tests
{
    [TestFixture]
    public class Lesson4Tests
    {
        [TestCase]
        public void PermCheck()
        {
            var instance = new PermCheck();

            Assert.AreEqual(1, instance.solution(new[] { 2, 3, 1 }));
            Assert.AreEqual(0, instance.solution(new[] { 2, 4, 1 }));
        }
    }
}
