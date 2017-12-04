namespace Blackjack.Core
{
    using System;

    public static class RankExtensions
    {
        public static char GetShortRank(this Rank rank)
        {
            switch (rank)
            {
                case Rank.Two: return '2';
                case Rank.Three: return '3';
                case Rank.Four: return '4';
                case Rank.Five: return '5';
                case Rank.Six: return '6';
                case Rank.Seven: return '7';
                case Rank.Eight: return '8';
                case Rank.Nine: return '9';
                case Rank.Ten: return 'T';
                case Rank.Jack: return 'J';
                case Rank.Queen: return 'Q';
                case Rank.King: return 'K';
                case Rank.Ace: return 'A';
                default: throw new InvalidOperationException();
            }
        }
    }
}