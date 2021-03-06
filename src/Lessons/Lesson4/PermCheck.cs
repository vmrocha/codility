﻿// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace Lessons.Lesson4.PermCheck
{
    public class Solution
    {
        public int solution(int[] A)
        {
            var found = new bool[A.Length];

            foreach (var num in A)
            {
                if (num < 1 || num > A.Length || found[num - 1])
                {
                    return 0;
                }

                found[num - 1] = true;
            }

            return 1;
        }
    }
}
