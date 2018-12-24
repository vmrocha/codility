// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace Lessons.Lesson7.StoneWall
{
    using System.Collections.Generic;

    public class Solution
    {
        public int solution(int[] H)
        {
            var counts = 1;
            var blocks = new Stack<int>();

            blocks.Push(H[0]);

            for (var i = 1; i < H.Length; i++)
            {
                if (blocks.Count == 0 || blocks.Peek() != H[i])
                {
                    while (blocks.Count > 0 && blocks.Peek() > H[i])
                    {
                        blocks.Pop();
                    }

                    if (blocks.Count > 0 && H[i] == blocks.Peek())
                    {
                        continue;
                    }

                    blocks.Push(H[i]);
                    counts++;
                }
            }

            return counts;
        }
    }
}
