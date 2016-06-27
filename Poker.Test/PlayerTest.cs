﻿using System;
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
        public void Hand_StartingValueIsNoScore()
        {
            Player testPlayer = new Poker.Player();
            Assert.AreEqual(-1, testPlayer.score);
        }

        [TestCase]
        public void DealCard_FillsHand()
        {
            Player testPlayer = new Poker.Player();
            Card cardOne = new Card(1, 1);
            testPlayer.DealCard(cardOne);
            Assert.Contains(cardOne, testPlayer.hand);

        }

        [TestCase]
        public void DealCard_ComputeScore()
        {
            Player testPlayer = new Poker.Player();
            Card cardOne = new Card(1, 1);
            Card cardTwo = new Card(2, 1);
            testPlayer.DealCard(cardOne);
            testPlayer.DealCard(cardOne);
            testPlayer.DealCard(cardOne);
            testPlayer.DealCard(cardOne);
            testPlayer.DealCard(cardTwo);
            Assert.AreEqual(914,testPlayer.score);
        }

        [TestCase]
        public void SwitchCard_SetRightCard()
        {
            Player testPlayer = new Poker.Player();
            Card cardOne = new Card(1, 1);
            Card cardTwo = new Card(2, 0);
            testPlayer.DealCard(cardOne);
            testPlayer.SwitchCard(cardTwo, 0);
            Assert.AreEqual(cardTwo, testPlayer.hand[0]);
            CollectionAssert.DoesNotContain(testPlayer.hand, cardOne);
        }

        [TestCase]
        public void SwitchCard_ComputeScore()
        {
            Player testPlayer = new Poker.Player();
            Card cardOne = new Card(1, 1);
            Card cardTwo = new Card(2, 1);
            testPlayer.DealCard(cardOne);
            testPlayer.DealCard(cardOne);
            testPlayer.DealCard(cardOne);
            testPlayer.DealCard(cardTwo);
            testPlayer.DealCard(cardTwo);
            testPlayer.SwitchCard(cardOne, 3);
            Assert.AreEqual(914, testPlayer.score);
        }



    }
}
