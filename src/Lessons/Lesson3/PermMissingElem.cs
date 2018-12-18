// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace Lessons.Lesson3.PermMissingElem
{
    public class Solution
    {
        public int solution(int[] A)
        {
            long n = A.Length + 1;
            long sum = n * (n + 1) / 2;
            foreach (var value in A)
            {
                sum -= value;
            }

            return (int)sum;
        }
    }
}
