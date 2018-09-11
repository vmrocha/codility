namespace Lessons.Lesson3
{
    public class FrogJmp
    {
        public int solution(int X, int Y, int D)
        {
            var diff = Y - X;

            if (diff % D == 0)
            {
                return diff / D;
            }

            return diff / D + 1;
        }
    }
}
