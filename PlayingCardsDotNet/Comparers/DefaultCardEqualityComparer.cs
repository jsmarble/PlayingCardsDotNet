using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingCardsDotNet
{
    public class DefaultCardEqualityComparer : IEqualityComparer<Card>
    {
        #region IEqualityComparer<Card> Members

        public bool Equals(Card x, Card y)
        {
            if (x == null && y == null)
                return true;
            else if (x == null || y == null)
                return false;
            else
                return x.FaceValue.Equals(y.FaceValue) && x.Suit.Equals(y.Suit);
        }

        public int GetHashCode(Card obj)
        {
            return 0;
        }

        #endregion
    }
}
