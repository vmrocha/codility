// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace Lessons.Lesson3.TapeEquilibrium
{
    using System;
    using System.Linq;

    public class Solution
    {
        public int solution(int[] A)
        {
            var sumA = A[0];
            var sumB = A.Sum() - sumA;
            var diff = Math.Abs(sumA - sumB);

            for (var i = 2; i < A.Length; i++)
            {
                sumA += A[i - 1];
                sumB -= A[i - 1];
                var currentDiff = Math.Abs(sumA - sumB);
                if (currentDiff < diff)
                {
                    diff = currentDiff;
                }
            }

            return diff;
        }
    }
}
