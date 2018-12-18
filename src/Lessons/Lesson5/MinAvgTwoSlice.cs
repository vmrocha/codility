// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace Lessons.Lesson5.MinAvgTwoSlice
{
    public class Solution
    {
        public int solution(int[] A)
        {
            var minIndex = 0;
            var minValue = double.MaxValue;

            for (var i = 0; i < A.Length - 1; i++)
            {
                var value = (A[i] + A[i + 1]) / 2d;
                if (value < minValue)
                {
                    minValue = value;
                    minIndex = i;
                }

                if (i < A.Length - 2)
                {
                    value = (A[i] + A[i + 1] + A[i + 2]) / 3d;
                    if (value < minValue)
                    {
                        minValue = value;
                        minIndex = i;
                    }
                }
            }

            return minIndex;
        }
    }
}
