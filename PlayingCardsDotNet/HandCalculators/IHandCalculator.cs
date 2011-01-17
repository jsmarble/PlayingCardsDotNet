using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingCardsDotNet
{
    public interface IHandCalculator
    {
        Hand GetHand(IEnumerable<Card> cards);
    }
}
