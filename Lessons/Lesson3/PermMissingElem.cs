using System.Linq;

namespace Lessons.Lesson3
{
    public class PermMissingElem
    {
        public int solution(int[] A)
        {
            var n = A.Length + 1;
            var sum = n * (n + 1) / 2;
            return sum - A.Sum();
        }
    }
}
