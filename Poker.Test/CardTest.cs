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
    class CardTest
    {
        [TestCase]
        public void Constructor_CorrectValues()
        {
            Card testCard = new Card(2,3);
            Assert.AreEqual(2, testCard.value);
            Assert.AreEqual(3, testCard.suit);
        }

        [TestCase]
        public void ToString_CorrectValues()
        {
            string expectedString = "2 of Clubs";
            Card testCard = new Card(2, 3);
            Assert.AreEqual(expectedString, testCard.ToString());
        }
    }
}
