using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit;
using NUnit.Framework;
using Poker;

namespace Poker.Test
{
    [TestFixture]
    class ScoreHelperTest
    {
        [TestCase]
        public void CalculateScore_IncompleteHand_IsMinusOne()
        {
            List<Card> emptyList = new List<Card>();
            int result = ScoreHelper.CalculateScore(emptyList);
            Assert.AreEqual(-1, result);
        }

        [TestCase]
        public void CalculateScore_RoyalFlush_Is914()
        {
            Card ace = new Card(14, 1);
            Card king = new Card(13, 1);
            Card queen = new Card(12, 1);
            Card jack = new Card(11, 1);
            Card ten = new Card(10, 1);  
            List<Card> hand = new List<Card> { ace, king, queen, jack, ten };
            int score = ScoreHelper.CalculateScore(hand);
            Assert.AreEqual(914, score);

        }
    }
}
