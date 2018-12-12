namespace Lessons.Lesson3
{
    public class FrogJmp
    {
        public int Solution(int X, int Y, int D)
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
