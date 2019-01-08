using Lessons.Lesson8.Dominator;
using NUnit.Framework;
using System.Linq;

namespace Lessons.Tests.Lesson8
{
    public class DominatorFixture
    {
        public void Solution(int expected, int[] a)
        {
            var instance = new Solution();

            var result = instance.solution(new[] { 3, 4, 3, 2, 3, -1, 3, 3 });

            Assert.IsTrue(new[] { 0, 2, 4, 6, 7 }.Contains(result));
        }
    }
}
