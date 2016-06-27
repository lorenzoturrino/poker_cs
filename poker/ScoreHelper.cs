﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public static class ScoreHelper
    {
        public static int CalculateScore(List<Card> cards)
        {
            if (cards.Count < 5)
            {
                return -1;
            }
            else if (cards.IsStraightflush())
            {
                return 914;
            }

            else return 0;
        }

        private static bool IsStraightflush(this List<Card> cards)
        {
            if (!cards.allSameSeed())
            {
                return false;
            }
            List<Card> orderedCards = cards.OrderBy(card => card.value).ToList();
            bool isAscending = cards
                .Select((card, index) => card.value + index)
                .All(value => value == cards[0].value);
            if(isAscending)
            {
                return true;
            }
            return false;
        }

        private static List<Card> sortCards(List<Card> cards)
        {
            return cards.OrderBy(card => card.value).ToList();
        }

        private static bool allSameSeed(this List<Card> cards)
        {
            return cards.All(card => card.suit == cards[0].suit);
        }
    }
}
