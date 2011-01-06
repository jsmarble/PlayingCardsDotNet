using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingCardsDotNet
{
    public class PairComparer : HandComparer<Pair>
    {
        public override int Compare(Pair x, Pair y)
        {
            return x.Cards.Max(card => card.NumericValue).CompareTo(y.Cards.Max(card => card.NumericValue));
        }

        public override bool CanCompare(Hand hand)
        {
            return hand is Pair;
        }
    }
}
