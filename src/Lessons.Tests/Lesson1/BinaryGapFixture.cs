using System;
using Lessons.Lesson1.BinaryGap;
using NUnit.Framework;

namespace Lessons.Tests.Lesson1
{
    [TestFixture]
    public class BinaryGapFixture
    {
        [TestCaseSource(nameof(Data))]
        public void Solution(int number, int expectedResult)
        {
            var instance = new Solution();
            Assert.AreEqual(expectedResult, instance.solution(number));
        }

        private static object[] Data => new object[] 
        {
            new [] {Convert.ToInt32("1", 2), 0 },
            new [] {Convert.ToInt32("11", 2), 0 },
            new [] {Convert.ToInt32("10", 2), 0 },
            new [] {Convert.ToInt32("111", 2), 0 },
            new [] {Convert.ToInt32("110", 2), 0 },
            new [] {Convert.ToInt32("101", 2), 1 },
            new [] {Convert.ToInt32("1111", 2), 0 },
            new [] {Convert.ToInt32("1101", 2), 1 },
            new [] {Convert.ToInt32("1011", 2), 1 },
            new [] {Convert.ToInt32("1001", 2), 2 },
            new [] {Convert.ToInt32("11111", 2), 0 },
            new [] {Convert.ToInt32("11011", 2), 1 },
            new [] {Convert.ToInt32("10101", 2), 1 },
            new [] {Convert.ToInt32("11001", 2), 2 },
            new [] {Convert.ToInt32("10001", 2), 3 }
        };
    }
}
