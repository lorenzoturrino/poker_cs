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
    class PlayerTest
    {
        [TestCase]
        public void Hand_StartsEmpty()
        {
            Player testPlayer = new Poker.Player();
            Assert.IsEmpty(testPlayer.hand);
        }

        [TestCase]
        public void DealCard_FillsHand()
        {
            Player testPlayer = new Poker.Player();
            Card cardOne = new Card(1, 1);
            testPlayer.dealCard(cardOne);
            Assert.Contains(cardOne, testPlayer.hand);

        }



    }
}
