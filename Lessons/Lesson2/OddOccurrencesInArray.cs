namespace Lessons.Lesson2
{
    public class OddOccurrencesInArray
    {
        public int solution(int[] A)
        {
            var result = 0;

            for (int i = 0; i < A.Length; i++)
            {
                result ^= A[i];
            }

            return result;
        }
    }
}
