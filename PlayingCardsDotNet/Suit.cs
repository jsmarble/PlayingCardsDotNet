using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingCardsDotNet
{
    public class Suit
    {
        public enum Color
        {
            Red,
            Black
        }

        internal Suit(string name, Color color)
        {
        }
    }

    public static class Suits
    {
        public static readonly Suit Hearts = new Suit("Hearts", Suit.Color.Red);
        public static readonly Suit Diamonds = new Suit("Diamonds", Suit.Color.Red);
        public static readonly Suit Spades = new Suit("Spades", Suit.Color.Black);
        public static readonly Suit Clubs = new Suit("Clubs", Suit.Color.Black);
    }
}
