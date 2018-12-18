// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace Lessons.Lesson3.FrogJmp
{
    public class Solution
    {
        public int solution(int X, int Y, int D)
        {
            var diff = Y - X;

            if (diff % D == 0)
            {
                return diff / D;
            }

            return diff / D + 1;
        }
    }
}
