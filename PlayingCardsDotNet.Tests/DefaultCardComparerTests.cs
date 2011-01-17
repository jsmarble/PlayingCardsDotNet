using PlayingCardsDotNet.Comparers;
using Xunit;

namespace PlayingCardsDotNet.Tests
{
    public class DefaultCardComparerTests
    {
        [Fact]
        public void FourClubs_Is_Greater_Than_TwoHearts()
        {
            DefaultCardComparer comparer = new DefaultCardComparer();
            Card fourClubs = new Card("4", 4, Suits.Clubs);
            Card twoHearts = new Card("2", 2, Suits.Hearts);
            Assert.Equal(1, comparer.Compare(fourClubs, twoHearts));
        }

        [Fact]
        public void JackDiamonds_Is_Less_Than_KingSpades()
        {
            DefaultCardComparer comparer = new DefaultCardComparer();
            Card kingSpades = new Card("4", 4, Suits.Clubs);
            Card jackDiamonds = new Card("2", 2, Suits.Hearts);
            Assert.Equal(-1, comparer.Compare(jackDiamonds, kingSpades));
        }
    }
}
