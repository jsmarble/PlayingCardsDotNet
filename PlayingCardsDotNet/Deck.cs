using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

namespace PlayingCardsDotNet
{
    public class Deck : IEnumerable<Card>
    {
        public Deck()
            : this(1)
        {
        }

        public Deck(int numberOfDecks)
        {
            this.NumberOfDecks = numberOfDecks;
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
            get { return GenerateJokers(this.JokersPerDeck); }
        }

        private int jokersPerDeck;
        public int JokersPerDeck
        {
            get { return jokersPerDeck; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("JokersPerDeck", "Value must be greater than zero.");
                jokersPerDeck = value;
            }
        }

        private int numberOfDecks;
        public int NumberOfDecks
        {
            get { return numberOfDecks; }
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException("NumberOfDecks", "Value must be greater than one.");
                numberOfDecks = value;
            }
        }

        public AceValue AceValue { get; set; }

        private IEnumerable<Card> GenerateJokers(int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException("count", "Value cannot be less than zero.");
            return Enumerable.Range(1, count).Select(x => new Card("Joker", 0, null)).Repeat(this.numberOfDecks);
        }

        private IEnumerable<Card> GenerateCards(Suit suit)
        {
            int aceNumeric = AceValue == AceValue.High ? 14 : 1;
            return Enumerable.Range(2, 12).Append(aceNumeric).Select(x => new Card(Card.NumericValueToFaceValue(x), x, suit)).Repeat(this.numberOfDecks);
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
