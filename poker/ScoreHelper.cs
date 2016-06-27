using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public static class ScoreHelper
    {
        public static int calculateScore(List<Card> cards)
        {
            if (cards.Count < 5)
            {
                return -1;
            }
            else
            {
                return 914;
            }
        }
    }
}
