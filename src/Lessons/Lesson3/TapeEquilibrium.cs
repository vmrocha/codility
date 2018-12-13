﻿// ReSharper disable InconsistentNaming

using System;
using System.Linq;

namespace Lessons.Lesson3
{
    public class TapeEquilibrium
    {
        public int Solution(int[] A)
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
