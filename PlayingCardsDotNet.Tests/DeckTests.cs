using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace PlayingCardsDotNet.Tests
{
    public class DeckTests
    {
        [Fact]
        public void New_Deck_Has_52_Cards()
        {
            Deck deck = new Deck();
            Assert.Equal(52, deck.Count());
        }

        [Fact]
        public void New_Deck_Has_13_Clubs()
        {
            Deck deck = new Deck();
            Assert.Equal(13, deck.Clubs.Count());
        }

        [Fact]
        public void New_Deck_Has_13_Spades()
        {
            Deck deck = new Deck();
            Assert.Equal(13, deck.Spades.Count());
        }

        [Fact]
        public void New_Deck_Has_13_Diamonds()
        {
            Deck deck = new Deck();
            Assert.Equal(13, deck.Diamonds.Count());
        }

        [Fact]
        public void New_Deck_Has_13_Hearts()
        {
            Deck deck = new Deck();
            Assert.Equal(13, deck.Hearts.Count());
        }

        [Fact]
        public void NumberOfJokers_Property_Affects_Number_Of_Jokers()
        {
            int numberOfJokers = 7;
            Deck deck = new Deck { JokersPerDeck = numberOfJokers };
            Assert.Equal(numberOfJokers, deck.Jokers.Count());
            numberOfJokers = 4;
            deck.JokersPerDeck = numberOfJokers;
            Assert.Equal(numberOfJokers, deck.Jokers.Count());
        }

        [Fact]
        public void Zero_Jokers_Returns_Empty_Joker_List()
        {
            Deck deck = new Deck { JokersPerDeck = 0 };
            Assert.Equal(0, deck.Jokers.Count());
        }

        [Fact]
        public void Deck_Is_IEnumerable()
        {
            Deck deck = new Deck();
            IEnumerable<Card> enumerable = deck as IEnumerable<Card>;
            Assert.NotNull(enumerable);
        }

        [Fact]
        public void AceValueHigh_Makes_Ace_Worth_More_Than_King()
        {
            Deck deck = new Deck { AceValue = AceValue.High };
            var ace = deck.Diamonds.First(x => x.FaceValue == "A");
            var king = deck.Diamonds.First(x => x.FaceValue == "K");
            Assert.True(ace.NumericValue > king.NumericValue);
        }

        [Fact]
        public void AceValueLow_Makes_Ace_Worth_Less_Than_Two()
        {
            Deck deck = new Deck { AceValue = AceValue.Low };
            var ace = deck.Diamonds.First(x => x.FaceValue == "A");
            var two = deck.Diamonds.First(x => x.FaceValue == "2");
            Assert.True(ace.NumericValue < two.NumericValue);
        }
    }
}
