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
    }
}
