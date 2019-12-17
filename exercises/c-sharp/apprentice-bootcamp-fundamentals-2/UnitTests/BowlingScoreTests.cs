using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using apprentice_bootcamp_fundamentals_2;

namespace UnitTests
{
    [TestFixture]
    public class BowlingScoreTests
    {
        [Test]
        public void WhenAllRollsZeroScoreIsZero()
        {
            Game game = new Game();
            int[] rolls = { 0,0, 0,0, 0,0, 0,0, 0,0, 0,0, 0,0, 0,0, 0,0, 0,0 };
            int score = game.score(rolls);

            Assert.AreEqual(0, score);
        }

        [Test]
        public void WhenAllRollsOneScoreIsTwenty()
        {
            Game game = new Game();
            int[] rolls = { 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1 };
            int score = game.score(rolls);

            Assert.AreEqual(20, score);
        }

        [Test]
        public void WhenSpareInFirstFrameBonusAwarded()
        {
            Game game = new Game();
            int[] rolls = { 1,9, 1,0, 0,0, 0,0, 0,0, 0,0, 0,0, 0,0, 0,0, 0,0 };
            int score = game.score(rolls);

            Assert.AreEqual(12, score);
        }

        [Test]
        public void WhenStrikeInFirstFrameBonusAwarded()
        {
            Game game = new Game();
            int[] rolls = { 10, 8,1, 0,0, 0,0, 0,0, 0,0, 0,0, 0,0, 0,0, 0,0 };
            int score = game.score(rolls);

            Assert.AreEqual(28, score);
        }

        [Test]
        public void WhenOneStrikeAndOneSpareOccurBothBonusesApplied()
        {
            Game game = new Game();
            int[] rolls = { 10, 8,2, 1,2, 0,0, 0,0, 0,0, 0,0, 0,0, 0,0, 0,0 };
            int score = game.score(rolls);

            Assert.AreEqual(34, score);
        }

        [Test]
        public void WhenTwoStrikeAndOneSpareOccurAllBonusesApplied()
        {
            Game game = new Game();
            int[] rolls = { 10, 8,2, 1,2, 0,0, 10, 2,1, 0,0, 0,0, 0,0, 0,0 };
            int score = game.score(rolls);

            Assert.AreEqual(50, score);
        }

    }
}
