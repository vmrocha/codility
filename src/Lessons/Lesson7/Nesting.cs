// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace Lessons.Lesson7.Nesting
{
    public class Solution
    {
        public int solution(string S)
        {
            var opens = 0;

            foreach (var c in S)
            {
                if (c == '(')
                {
                    opens++;
                }
                else if (c == ')')
                {
                    if (opens == 0)
                    {
                        return 0;
                    }

                    opens--;
                }
            }

            return opens == 0 ? 1 : 0;
        }
    }
}
