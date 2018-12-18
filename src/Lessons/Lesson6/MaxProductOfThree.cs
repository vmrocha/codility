// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace Lessons.Lesson6.MaxProductOfThree
{
    using System;

    public class Solution
    {
        public int solution(int[] A)
        {
            Array.Sort(A);
            var l = A.Length;
            return Math.Max(A[l - 3] * A[l - 2] * A[l - 1], A[0] * A[1] * A[l - 1]);
        }
    }
}
