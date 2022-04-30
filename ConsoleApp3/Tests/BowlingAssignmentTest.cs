using NUnit.Framework;

namespace BowlingAssignment.Tests
{
    [TestFixture]
    internal class BowlingAssignmentTest
    {
        BowlingGame game;

        public BowlingAssignmentTest()
        {
        }

        [SetUp]
        public void SetUp()
        {
            game = new BowlingGame();
        }

        [Test]
        public void AllZeroScoreBalls()
        {
            ManyFrames(10, 0, 0);
            Assert.AreEqual(0, game.Score());
        }

        [Test]
        public void SampleTest()
        {
            ManyFrames(10, 8, 3);
            Assert.AreEqual(110, game.Score());
        }

        [Test]
        public void Spare()
        {
            game.Spare(4, 6);
            game.OpenFrame(5, 5);
            ManyFrames(8, 0, 0);
            Assert.AreEqual(25, game.Score());
        }

        [Test]
        public void Strike()
        {
            game.Strike();
            game.OpenFrame(5, 5);
            ManyFrames(8, 0, 0);
            Assert.AreEqual(30, game.Score());
        }

        private void ManyFrames(int count, int firstThrow, int secondThrow)
        {
            for (int frameNumber = 0; frameNumber < count; frameNumber++)
                game.OpenFrame(firstThrow, secondThrow);
        }
    }
}
