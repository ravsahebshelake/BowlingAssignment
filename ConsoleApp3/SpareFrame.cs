using System.Collections;

namespace BowlingAssignment
{
    public class SpareFrame : Frame
    {
        public SpareFrame(ArrayList throws, int startingThrow, int firstThrow, int secondThrow) : base(throws)
        {
            throws.Add(firstThrow);
            throws.Add(secondThrow);
        }

        private int NextBall()
        {
            return (int)throws[startingThrow + 2];
        }

        public override int Score()
        {
            return 10 + NextBall(); ;
        }

        override protected int FrameSize()
        {
            return 2;
        }
    }
}
