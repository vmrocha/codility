// ReSharper disable InconsistentNaming

using System.Linq;

namespace Lessons.Lesson3
{
    public class PermMissingElem
    {
        public int Solution(int[] A)
        {
            long n = A.Length + 1;
            long sum = n * (n + 1) / 2;
            foreach (var value in A)
            {
                sum -= value;
            }

            return (int)sum;
        }
    }
}
