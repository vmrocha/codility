// ReSharper disable InconsistentNaming

using System;

namespace Lessons.Lesson6
{
    public class Triangle
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
