using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingCardsDotNet
{
    public class FlushComparer : HandComparer<Flush>
    {
        public override bool CanCompare(Hand hand)
        {
            return hand is Flush;
        }

        public override int Compare(Flush x, Flush y)
        {
            //TODO: Handle tie for highest card
            return x.Cards.Max(card => card.NumericValue).CompareTo(y.Cards.Max(card => card.NumericValue));
        }
    }
}
