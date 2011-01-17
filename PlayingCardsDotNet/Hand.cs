using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingCardsDotNet
{
    public class Hand
    {
        public Hand(string name, IEnumerable<Card> cards)
        {
            Name = name;
            Cards = cards;
        }

        public string Name { get; private set; }
        public IEnumerable<Card> Cards { get; private set; }
    }
}
