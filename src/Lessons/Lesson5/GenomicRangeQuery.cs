// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace Lessons.Lesson5.GenomicRangeQuery
{
    using System.Collections.Generic;

    public class Solution
    {
        public int[] solution(string S, int[] P, int[] Q)
        {
            var result = new int[Q.Length];
            var prefix = new Dictionary<char, int[]>
            {
                { 'A', new int[S.Length + 1] },
                { 'C', new int[S.Length + 1] },
                { 'G', new int[S.Length + 1] }
            };

            prefix['A'][0] = S[0] == 'A' ? 1 : 0;
            prefix['C'][0] = S[0] == 'C' ? 1 : 0;
            prefix['G'][0] = S[0] == 'G' ? 1 : 0;

            for (var i = 0; i < S.Length; i++)
            {
                prefix['A'][i + 1] = prefix['A'][i] + (S[i] == 'A' ? 1 : 0);
                prefix['C'][i + 1] = prefix['C'][i] + (S[i] == 'C' ? 1 : 0);
                prefix['G'][i + 1] = prefix['G'][i] + (S[i] == 'G' ? 1 : 0);
            }

            for (var i = 0; i < P.Length; i++)
            {
                var a = P[i];
                var b = Q[i];

                if (prefix['A'][b + 1] - prefix['A'][a] > 0)
                {
                    result[i] = 1;
                }
                else if (prefix['C'][b + 1] - prefix['C'][a] > 0)
                {
                    result[i] = 2;
                }
                else if (prefix['G'][b + 1] - prefix['G'][a] > 0)
                {
                    result[i] = 3;
                }
                else
                {
                    result[i] = 4;
                }
            }

            return result;
        }
    }
}
