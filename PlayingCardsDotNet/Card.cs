using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingCardsDotNet
{
    public class Card
    {
        public Card(string faceValue, int numericValue, Suit suit)
        {
            Suit = suit;
            NumericValue = numericValue;
            FaceValue = faceValue;

        }
        public string FaceValue { get; set; }
        public int NumericValue { get; set; }
        public Suit Suit { get; set; }

        public static string NumericValueToFaceValue(int value)
        {
            switch (value)
            {
                case 11:
                    return "J";
                case 12:
                    return "Q";
                case 13:
                    return "K";
                case 14:
                case 1:
                    return "A";
                default:
                    return value.ToString();
            }
        }
    }
}
