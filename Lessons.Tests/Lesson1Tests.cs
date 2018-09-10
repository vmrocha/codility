using System;
using Lessons.Lesson1;
using NUnit.Framework;

namespace Lessons.Tests
{
    [TestFixture]
    public class Lesson1Tests
    {
        [TestCase]
        public void BinaryGapTests()
        {
            var instance = new BinaryGap();

            Assert.AreEqual(0, instance.solution(Convert.ToInt32("1")));

            Assert.AreEqual(0, instance.solution(Convert.ToInt32("11", 2)));
            Assert.AreEqual(0, instance.solution(Convert.ToInt32("10", 2)));

            Assert.AreEqual(0, instance.solution(Convert.ToInt32("111", 2)));
            Assert.AreEqual(0, instance.solution(Convert.ToInt32("110", 2)));
            Assert.AreEqual(1, instance.solution(Convert.ToInt32("101", 2)));

            Assert.AreEqual(0, instance.solution(Convert.ToInt32("1111", 2)));
            Assert.AreEqual(1, instance.solution(Convert.ToInt32("1101", 2)));
            Assert.AreEqual(1, instance.solution(Convert.ToInt32("1011", 2)));
            Assert.AreEqual(2, instance.solution(Convert.ToInt32("1001", 2)));

            Assert.AreEqual(0, instance.solution(Convert.ToInt32("11111", 2)));
            Assert.AreEqual(1, instance.solution(Convert.ToInt32("11011", 2)));
            Assert.AreEqual(1, instance.solution(Convert.ToInt32("10101", 2)));
            Assert.AreEqual(2, instance.solution(Convert.ToInt32("10011", 2)));
            Assert.AreEqual(2, instance.solution(Convert.ToInt32("11001", 2)));
            Assert.AreEqual(3, instance.solution(Convert.ToInt32("10001", 2)));
        }
    }
}
