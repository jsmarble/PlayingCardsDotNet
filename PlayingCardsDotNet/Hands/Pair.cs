using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Extended;
using System.Text;

namespace PlayingCardsDotNet
{
    public class Pair : Hand
    {
        public Pair(IEnumerable<Card> cards)
            : base(8, "Pair", cards)
        {
        }

        public static Pair GetHand(IEnumerable<Card> cards)
        {
            var flush = cards.GroupBy(x => x.FaceValue).Where(x => x.ContainsAtLeast(2)).Select(x => new Pair(x)).OrderByDescending(new PairComparer()).FirstOrDefault();
            return flush;
        }
    }
}
