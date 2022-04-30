using System.Collections;

namespace BowlingAssignment
{
    public class StrikeFrame : Frame
    {
        public StrikeFrame(ArrayList throws):base(throws)
        {
            throws.Add(10);
        }

        private int FirstFollowingBall()
        {
            return (int)throws[startingThrow + 1];
        }

        private int SecondFollowingBall()
        {
            return (int)throws[startingThrow + 2];
        }

        public override int Score()
        {
            return 10 + FirstBonusBall() + SecondBonusBall();
        }

        override protected int FrameSize()
        {
            return 1;
        }
    }
}
