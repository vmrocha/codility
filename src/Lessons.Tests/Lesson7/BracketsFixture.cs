using Lessons.Lesson7.Brackets;
using NUnit.Framework;

namespace Lessons.Tests.Lesson7
{
    class BracketsFixture
    {
        [TestCaseSource(nameof(Data))]
        public void Solution(int expected, string s)
        {
            var instance = new Solution();
            Assert.AreEqual(expected, instance.solution(s));
        }

        private static object[] Data => new object[]
        {
            new object[] { 1, "{[()()]}" },
            new object[] { 0, "([)()]" },
            new object[] { 1, "(U)" },
            new object[] { 1, "{U}" },
            new object[] { 1, "[U]" },
            new object[] { 0, "{[U]" },
            new object[] { 0, "[U]}" }
        };
    }
}
