using System.Collections.Generic;
using System.Linq;

namespace PlayingCardsDotNet
{
    public static class Extensions
    {
        public static IEnumerable<IEnumerable<Card>> Deal(this IEnumerable<Card> cards, int hands, int cardsPerHand)
        {
            int totalCards = hands * cardsPerHand;
            return cards.Take(totalCards).Batch(cardsPerHand);
        }

        public static Hand GetHand(this IEnumerable<Card> cards, IHandCalculator handCalculator)
        {
            return handCalculator.GetHand(cards);
        }
    }
}
