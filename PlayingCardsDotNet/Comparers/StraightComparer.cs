using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingCardsDotNet
{
    public class StraightComparer:HandComparer<Straight>
    {
        public override bool CanCompare(Hand hand)
        {
            return hand is Straight;
        }

        public override int Compare(Straight x, Straight y)
        {
            //TODO: Handle tie for highest card
            return x.Cards.Max(card => card.NumericValue).CompareTo(y.Cards.Max(card => card.NumericValue));
        }
    }
}
