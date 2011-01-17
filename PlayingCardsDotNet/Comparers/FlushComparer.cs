using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingCardsDotNet.Comparers
{
    public class FlushComparer : IComparer<Hand>
    {
        public int Compare(Hand x, Hand y)
        {
            //TODO: Handle tie for highest card
            return x.Cards.Max(card => card.NumericValue).CompareTo(y.Cards.Max(card => card.NumericValue));
        }
    }
}
