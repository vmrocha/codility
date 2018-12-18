// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace Lessons.Lesson4.MissingInteger
{
    public class Solution
    {
        public int solution(int[] A)
        {
            var found = new bool[A.Length];

            foreach (var n in A)
            {
                if (n > 0 && n <= A.Length)
                {
                    found[n - 1] = true;
                }
            }

            for (int i = 0; i < found.Length; i++)
            {
                if (!found[i])
                {
                    return i + 1;
                }
            }

            return A.Length + 1;
        }
    }
}
