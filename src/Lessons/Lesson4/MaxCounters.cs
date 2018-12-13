// ReSharper disable InconsistentNaming

using System;

namespace Lessons.Lesson4
{
    public class MaxCounters
    {
        public int[] Solution(int N, int[] A)
        {
            var result = new int[N];
            var max = 0;
            var increase = 0;

            foreach (var x in A)
            {
                if (x > N)
                {
                    increase = max;
                }
                else
                {
                    result[x - 1] = Math.Max(result[x - 1], increase);
                    result[x - 1]++;
                    max = Math.Max(max, result[x - 1]);
                }
            }

            for (var i = 0; i < N; i++)
            {
                result[i] = Math.Max(result[i], increase);
            }

            return result;
        }
    }
}
