// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace Lessons.Lesson5.CountDiv
{
    public class Solution
    {
        public int solution(int A, int B, int K)
        {
            return B / K - A / K + (A % K == 0 ? 1 : 0);
        }
    }
}
