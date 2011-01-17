using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingCardsDotNet.Comparers
{
    public class DefaultCardComparer : IComparer<Card>
    {
        #region IComparer<Card> Members

        public int Compare(Card x, Card y)
        {
            return x.NumericValue.CompareTo(y.NumericValue);
        }

        #endregion
    }
}
