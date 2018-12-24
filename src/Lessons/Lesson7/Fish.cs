// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace Lessons.Lesson7.Fish
{
    using System.Collections.Generic;

    public class Solution
    {
        public int solution(int[] A, int[] B)
        {
            var usSurvivals = 0;
            var dsSizes = new Stack<int>();

            for (var i = 0; i < A.Length; i++)
            {
                var currentSize = A[i];
                var currentFlow = B[i];

                if (currentFlow == 1)
                {
                    dsSizes.Push(currentSize);
                }
                else
                {
                    while (dsSizes.Count > 0 && currentSize > dsSizes.Peek())
                    {
                        dsSizes.Pop();
                    }

                    if (dsSizes.Count == 0)
                    {
                        usSurvivals++;
                    }
                }
            }

            return usSurvivals + dsSizes.Count;
        }
    }
}
