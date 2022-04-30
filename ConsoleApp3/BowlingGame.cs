using System.Collections;

namespace BowlingAssignment
{
    public class BowlingGame
    {
        ArrayList frames;
        ArrayList throws;

        public BowlingGame()
        {
            frames = new ArrayList();
            throws = new ArrayList();
        }

        public void OpenFrame(int firstThrow, int secondThrow)
        {
            frames.Add(new OpenFrame(throws, firstThrow, secondThrow));
        }

        public void Spare(int firstThrow, int secondThrow)
        {
            throws.Add((int)firstThrow);
            throws.Add(((int)secondThrow));
            frames.Add(new SpareFrame(throws, throws.Count, firstThrow, secondThrow));
        }

        public void Strike()
        {
            frames.Add(new StrikeFrame(throws));
        }

        public int Score()
        {
            int total = 0;
            foreach (IFrame frame in frames)
                total += frame.Score();
            return total;
        }
    }
}
