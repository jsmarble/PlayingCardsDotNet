using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingCardsDotNet.Comparers
{
    public class PairComparer : IComparer<Hand>
    {
        public int Compare(Hand x, Hand y)
        {
            //TODO: Make a full implementation of hand comparison.
            return x.Cards.Max(card => card.NumericValue).CompareTo(y.Cards.Max(card => card.NumericValue));
        }
    }
}
