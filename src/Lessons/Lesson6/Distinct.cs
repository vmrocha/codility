// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace Lessons.Lesson6.Distinct
{
    using System.Collections.Generic;

    public class Solution
    {
        public int solution(int[] A)
        {
            var set = new HashSet<int>();

            foreach (var value in A)
            {
                set.Add(value);
            }

            return set.Count;
        }
    }
}
