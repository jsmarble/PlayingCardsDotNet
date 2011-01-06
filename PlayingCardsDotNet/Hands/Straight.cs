using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingCardsDotNet
{
    public class Straight : Hand
    {
        public Straight(IEnumerable<Card> cards)
            : base(5, "Straight", cards)
        {
        }

        public static Straight GetHand(IEnumerable<Card> cards)
        {
            return null;
        }
    }
}
