// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace Lessons.Lesson6.Triangle
{
    using System;

    public class Solution
    {
        public int solution(int[] A)
        {
            Array.Sort(A);

            for (int i = 0; i < A.Length - 2; i++)
            {
                if ((long)A[i] + A[i + 1] > A[i + 2])
                {
                    return 1;
                }
            }

            return 0;
        }
    }
}
