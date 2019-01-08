// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace Lessons.Lesson8.Dominator
{
    public class Solution
    {
        public int solution(int[] A)
        {
            var size = 0;
            var value = 0;

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
                var count = 0;
                var lasti = 0;

                for (var i = 0; i < A.Length; i++)
                {
                    if (A[i] == value)
                    {
                        count++;
                        lasti = i;
                    }
                }

                if (count > A.Length / 2)
                {
                    return lasti;
                }
            }

            return -1;
        }
    }
}
