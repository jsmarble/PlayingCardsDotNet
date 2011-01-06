using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Extended;
using System.Text;

namespace PlayingCardsDotNet
{
    public class Flush : Hand
    {
        public Flush(IEnumerable<Card> cards)
            : base(4, "Flush", cards)
        {
        }

        public static Flush GetHand(IEnumerable<Card> cards)
        {
            var flush = cards.GroupBy(x => x.Suit).Where(x => x.ContainsAtLeast(5)).Select(x => new Flush(x)).OrderByDescending(new FlushComparer()).FirstOrDefault();
            return flush;
        }
    }
}
