using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Extended;
using System.Text;

namespace PlayingCardsDotNet
{
    public class Deck : IEnumerable<Card>
    {
        public Deck()
        {
        }

        public IEnumerable<Card> Hearts
        {
            get { return GenerateCards(Suits.Hearts); }
        }

        public IEnumerable<Card> Clubs
        {
            get { return GenerateCards(Suits.Clubs); }
        }

        public IEnumerable<Card> Spades
        {
            get { return GenerateCards(Suits.Spades); }
        }

        public IEnumerable<Card> Diamonds
        {
            get { return GenerateCards(Suits.Diamonds); }
        }

        public IEnumerable<Card> Jokers
        {
            get { return GenerateJokers(this.NumberOfJokers); }
        }

        private int numberOfJokers;
        public int NumberOfJokers
        {
            get { return numberOfJokers; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("NumberOfJokers", "Value cannot be less than zero.");
                numberOfJokers = value;
            }
        }
        public AceValue AceValue { get; set; }

        private static IEnumerable<Card> GenerateJokers(int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException("count", "Value cannot be less than zero.");
            return Enumerable.Range(1, count).Select(x => new Card("Joker", 0, null));
        }

        private IEnumerable<Card> GenerateCards(Suit suit)
        {
            int aceNumeric = AceValue == AceValue.High ? 14 : 1;
            return Enumerable.Range(2, 12).Append(aceNumeric).Select(x => new Card(Card.NumericValueToFaceValue(x), x, suit));
        }

        #region IEnumerable<Card> Members

        public IEnumerator<Card> GetEnumerator()
        {
            IEnumerable<Card> cards = Hearts.Concat(Clubs).Concat(Spades).Concat(Diamonds);
            return cards.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}
