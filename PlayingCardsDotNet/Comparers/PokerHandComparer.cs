using System;
using System.Collections.Generic;

namespace PlayingCardsDotNet.Comparers
{
    public class PokerHandComparer : IComparer<Hand>
    {
        #region IComparer<Hand> Members

        public int Compare(Hand x, Hand y)
        {
            int rankX = GetHandRank(x);
            int rankY = GetHandRank(y);
            int result = rankX.CompareTo(rankY);
            if (result == 0)
            {
                //TODO: Compare actual hands.
                var comparer = GetHandComparer(x);
                return comparer.Compare(x, y);
            }
            return result;
        }

        #endregion

        private static IComparer<Hand> GetHandComparer(Hand value)
        {
            throw new NotImplementedException();
        }

        private static int GetHandRank(Hand value)
        {
            // http://www.pagat.com/poker/rules/ranking.html
            if (value.Name == "Flush")
            {
                if (false)//if(value is Straight Flush)
                {
                    return 1;
                }
                return 4;
            }
            else if (value.Name == "Straight")
            {
                return 5;
            }
            else if (value.Name == "Pair")
            {
                return 8;
            }
            else
                throw new NotSupportedException();
        }
    }
}
