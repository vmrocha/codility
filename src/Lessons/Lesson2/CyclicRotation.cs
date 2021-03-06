﻿// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace Lessons.Lesson2.CyclicRotation
{
    public class Solution
    {
        public int[] solution(int[] A, int K)
        {
            if (A.Length < 2)
            {
                return A;
            }

            for (var i = 0; i < K; i++)
            {
                for (var j = A.Length - 1; j > 0; j--)
                {
                    var temp = A[j];
                    A[j] = A[j - 1];
                    A[j - 1] = temp;
                }
            }

            return A;
        }
    }
}
