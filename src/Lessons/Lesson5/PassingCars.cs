// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace Lessons.Lesson5.PassingCars
{
    public class Solution
    {
        private const int EAST = 0;
        private const int WEST = 1;

        public int solution(int[] A)
        {
            var total = 0;
            var count = 0;

            foreach (var direction in A)
            {
                if (direction == EAST)
                {
                    count++;
                }

                if (count > 0 && direction == WEST)
                {
                    total += count;
                    if (total > 1000000000)
                    {
                        return -1;
                    }
                }
            }

            return total;
        }
    }
}
