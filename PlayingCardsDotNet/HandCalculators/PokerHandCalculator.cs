using System.Collections.Generic;
using System.Linq;
using PlayingCardsDotNet.Comparers;

namespace PlayingCardsDotNet.HandCalculators
{
    public class PokerHandCalculator : IHandCalculator
    {
        private static List<IHandCalculator> handCalculators = new List<IHandCalculator>();

        #region IHandCalculator Members

        public Hand GetHand(IEnumerable<Card> cards)
        {
            var handCalculators = GetHandCalculators();
            return handCalculators.Select(x => x.GetHand(cards)).OrderBy(new PokerHandComparer()).FirstOrDefault();
        }

        #endregion

        private IEnumerable<IHandCalculator> GetHandCalculators()
        {
            if (handCalculators.Count == 0)
            {
                lock (handCalculators)
                {
                    if (handCalculators.Count == 0)
                    {
                        handCalculators.Add(new PairCalculator());
                        handCalculators.Add(new FlushCalculator());
                    }
                }
            }
            return handCalculators;
        }
    }
}
