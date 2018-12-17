// ReSharper disable InconsistentNaming

using System.Collections.Generic;

namespace Lessons.Lesson6
{
    public class Distinct
    {
        public int solution(int[] A)
        {
            var set = new HashSet<int>();

            for (var i = 0; i < A.Length; i++)
            {
                set.Add(A[i]);
            }

            return set.Count;
        }
    }
}
