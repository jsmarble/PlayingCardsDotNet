using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingCardsDotNet
{
    public abstract class HandComparer<T> : HandComparer, IComparer<T> where T : Hand
    {
        #region IComparer<T> Members

        public abstract int Compare(T x, T y);

        #endregion
    }

    public abstract class HandComparer : IComparer<Hand>
    {
        public abstract bool CanCompare(Hand hand);
        #region IComparer<Hand> Members

        public int Compare(Hand x, Hand y)
        {
            return x.Rank.CompareTo(y.Rank);
        }

        #endregion
    }

    public static class HandComparers
    {
        public static readonly HandComparer FlushComparer = new FlushComparer();
        public static readonly HandComparer StraightComparer = new StraightComparer();

        public static readonly IEnumerable<HandComparer> All = new HandComparer[] { FlushComparer, StraightComparer };
    }
}
