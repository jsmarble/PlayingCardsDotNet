using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingCardsDotNet
{
    public enum SuitColor
    {
        Red,
        Black
    }

    public class Suit
    {
        protected internal Suit(string name, SuitColor color)
        {
            Color = color;
            Name = name;
        }

        public override string ToString()
        {
            return this.Name;
        }

        public string Name { get; protected set; }
        public SuitColor Color { get; protected set; }
    }

    public static class Suits
    {
        public static readonly Suit Hearts = new Suit("Hearts", SuitColor.Red);
        public static readonly Suit Diamonds = new Suit("Diamonds", SuitColor.Red);
        public static readonly Suit Spades = new Suit("Spades", SuitColor.Black);
        public static readonly Suit Clubs = new Suit("Clubs", SuitColor.Black);
    }
}
