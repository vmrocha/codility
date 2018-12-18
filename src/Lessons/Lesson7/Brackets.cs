// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace Lessons.Lesson7.Brackets
{
    using System.Collections.Generic;

    public class Solution
    {
        public int solution(string S)
        {
            var opens = new Stack<char>();

            foreach (var c in S)
            {
                if (c == '{' || c == '[' || c == '(')
                {
                    opens.Push(c);
                }
                else if (c == '}' || c == ']' || c == ')')
                {
                    if (opens.Count == 0)
                    {
                        return 0;
                    }

                    var open = opens.Pop();
                    if (open != '{' && c == '}' ||
                        open != '(' && c == ')' ||
                        open != '[' && c == ']')
                    {
                        return 0;
                    }
                }
            }

            return opens.Count == 0 ? 1 : 0;
        }
    }
}
