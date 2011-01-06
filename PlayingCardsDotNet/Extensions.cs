using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Extended;
using System.Text;

namespace PlayingCardsDotNet
{
    public static class Extensions
    {
        public static IEnumerable<IEnumerable<Card>> Deal(this IEnumerable<Card> cards, int hands, int cardsPerHand)
        {
            int totalCards = hands * cardsPerHand;
            return cards.Take(totalCards).Batch(cardsPerHand);
        }
    }
}
