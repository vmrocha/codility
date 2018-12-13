// ReSharper disable InconsistentNaming

using System;

namespace Lessons.Lesson1
{
    public class BinaryGap
    {
        public int Solution(int N)
        {
            var binary = Convert.ToString(N, 2);
            var gap = 0;

            for (var i = 0; i < binary.Length - 1; i++)
            {
                for (var j = i + 1; j < binary.Length; j++)
                {
                    if (binary[j] == '1')
                    {
                        if (gap < j - i)
                        {
                            gap = j - i - 1;
                        }

                        i = j - 1;
                        break;
                    }
                }
            }

            return gap;
        }
    }
}
