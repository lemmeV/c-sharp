﻿namespace Blackjack.Core
{
    public class Card
    {
        public string Description => $"{_rank.GetShortRank()}{_suite.GetShortName()}";

        public bool Hidden { get; set; }

        private readonly Rank _rank;

        private readonly Suite _suite;

        private readonly int _points;

        public Card(Rank rank, Suite suite, int points, bool hidden)
        {
            _rank = rank;
            _suite = suite;
            _points = points;

            this.Hidden = hidden;
        }        
    }
}
