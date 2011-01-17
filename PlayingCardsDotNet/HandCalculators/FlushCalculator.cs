using System.Collections.Generic;
using System.Linq;
using PlayingCardsDotNet.Comparers;

namespace PlayingCardsDotNet.HandCalculators
{
    public class FlushCalculator : IHandCalculator
    {
        #region IHandCalculator Members

        public Hand GetHand(IEnumerable<Card> cards)
        {
            var flush = cards.GroupBy(x => x.Suit).Where(x => x.ContainsAtLeast(5)).Select(x => new Hand("Flush", x)).OrderByDescending(new FlushComparer()).FirstOrDefault();
            return flush;
        }

        #endregion
    }
}
