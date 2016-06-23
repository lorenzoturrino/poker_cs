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
    class CardDealerTest
    {
        [TestCase]
        public void Constructor_CorrectValue()
        {
            Card cardOne = new Card(1, 1);
            Card cardTwo = new Card(2, 1);
            Card cardThree = new Card(3, 1);
            List<Card> cardList = new List<Card> { cardOne, cardTwo, cardThree };
            CardDealer dealer = new CardDealer(cardList);
            Assert.AreEqual(cardOne, dealer.GetCard());
            Assert.AreEqual(cardTwo, dealer.GetCard());
            Assert.AreEqual(cardThree, dealer.GetCard());

        }

        [TestCase]
        public void ScrambleDeck_ShuffleValues()
        {
            Card cardOne = new Card(1, 1);
            Card cardTwo = new Card(2, 1);
            Card cardThree = new Card(3, 1);
            List<Card> cardList = new List<Card> { cardOne, cardTwo, cardThree };
            CardDealer dealer = new CardDealer(cardList, randSeed: 2);
            dealer.ScrambleDeck();
            Assert.AreEqual(cardThree,dealer.GetCard());
            Assert.AreEqual(cardOne, dealer.GetCard());
            Assert.AreEqual(cardTwo, dealer.GetCard());
        }
    }
}
