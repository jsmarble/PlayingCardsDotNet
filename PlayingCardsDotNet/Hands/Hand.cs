using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingCardsDotNet
{
    public abstract class Hand : IComparable<Hand>
    {
        protected internal Hand(int rank, string name, IEnumerable<Card> cards)
        {
            Name = name;
            Rank = rank;
            Cards = cards;
        }

        public virtual bool Trumps(Hand other)
        {
            return this.CompareTo(other) == -1;
        }

        public int Rank { get; private set; }
        public string Name { get; private set; }
        public IEnumerable<Card> Cards { get; private set; }

        private static HandComparer GetComparerForHandType(Hand hand)
        {
            return HandComparers.All.SingleOrDefault(x => x.CanCompare(hand));
        }

        public static IEnumerable<Hand> GetHands(IEnumerable<Card> cards)
        {
            List<Hand> hands = new List<Hand>();
            hands.Add(Flush.GetHand(cards));
            hands.Add(Straight.GetHand(cards));
            hands.Add(Pair.GetHand(cards));
            return hands.Where(x => x != null).ToList();
        }

        #region IComparable<Hand> Members

        public int CompareTo(Hand other)
        {
            if (this.Rank != other.Rank)
                return this.Rank.CompareTo(other.Rank);
            else
            {
                HandComparer comparer = GetComparerForHandType(this);
                if (comparer == null)
                    throw new InvalidOperationException(string.Format("No comparer found that supports type '{0}'.", this.GetType().Name));
                return comparer.Compare(this, other);
            }
        }

        #endregion
    }
}
