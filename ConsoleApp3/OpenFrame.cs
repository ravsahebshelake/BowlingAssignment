using System.Collections;

namespace BowlingAssignment
{
    public class OpenFrame : Frame
    {
        public OpenFrame(ArrayList throws, int firstThrow, int secondThrow): base(throws)
        {
            throws.Add(firstThrow);
            throws.Add(secondThrow);
        }

        public override int Score()
        {
            return (int)throws[startingThrow] + (int)throws[startingThrow + 1];
        }

        override protected int FrameSize()
        {
            return 2;
        }
    }
}
