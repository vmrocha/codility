﻿namespace Lessons.Lesson4
{
    public class FrogJumpOne
    {
        public int Solution(int X, int[] A)
        {
            var found = new bool[X];

            var count = 0;

            for (var i = 0; i < A.Length; i++)
            {
                var number = A[i];

                if (number <= X && !found[number - 1])
                {
                    found[number - 1] = true;
                    count++;
                }

                if (count == X)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
