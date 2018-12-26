// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace Lessons.Lesson8.EquiLeader
{
    public class Solution
    {
        public int solution(int[] A)
        {
            var size   = 0;
            var value  = 0;
            var count  = 0;
            var total  = 0;
            var result = 0;

            for (var i = 0; i < A.Length; i++)
            {
                if (size == 0)
                {
                    size++;
                    value = A[i];
                }
                else
                {
                    if (value != A[i])
                    {
                        size--;
                    }
                    else
                    {
                        size++;
                    }
                }
            }

            if (size > 0)
            {
                for (var i = 0; i < A.Length; i++)
                {
                    if (value == A[i])
                    {
                        total++;
                    }
                }

                for (var i = 0; i < A.Length; i++)
                {
                    if (value == A[i])
                    {
                        count++;
                    }

                    if (count > (i + 1) / 2 && (total - count) > (A.Length - (i + 1)) / 2)
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
