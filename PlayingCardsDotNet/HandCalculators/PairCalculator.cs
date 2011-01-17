using System.Collections.Generic;
using System.Linq;
using PlayingCardsDotNet.Comparers;

namespace PlayingCardsDotNet.HandCalculators
{
    public class PairCalculator : IHandCalculator
    {
        #region IHandCalculator Members

        public Hand GetHand(IEnumerable<Card> cards)
        {
            var pair = cards.GroupBy(x => x.FaceValue).Where(x => x.ContainsAtLeast(2)).Select(x => new Hand("Pair", x)).OrderByDescending(new PairComparer()).FirstOrDefault();
            return pair;
        }

        #endregion
    }
}
