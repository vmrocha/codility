namespace Lessons.Lesson4
{
    public class PermCheck
    {
        public int solution(int[] A)
        {
            var found = new bool[A.Length];

            foreach (var num in A)
            {
                if (num < 1 || num > A.Length || found[num - 1])
                {
                    return 0;
                }

                found[num - 1] = true;
            }

            return 1;
        }
    }
}
