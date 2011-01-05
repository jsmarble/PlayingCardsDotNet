using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingCardsDotNet
{
    public class Deck
    {
        public Deck()
        {
            hearts = GenerateCards(Suits.Hearts);
            clubs = GenerateCards(Suits.Clubs);
            spades = GenerateCards(Suits.Spades);
            diamonds = GenerateCards(Suits.Diamonds);
        }

        private IEnumerable<Card> hearts;
        public IEnumerable<Card> Hearts
        {
            get { return hearts.ToList(); }
        }

        private IEnumerable<Card> clubs;
        public IEnumerable<Card> Clubs
        {
            get { return clubs.ToList(); }
        }

        private IEnumerable<Card> spades;
        public IEnumerable<Card> Spades
        {
            get { return spades.ToList(); }
        }

        private IEnumerable<Card> diamonds;
        public IEnumerable<Card> Diamonds
        {
            get { return diamonds.ToList(); }
        }

        private IEnumerable<Card> GenerateCards(Suit suit)
        {
            throw new NotImplementedException();
        }
    }
}
