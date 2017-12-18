namespace Blackjack.Core
{
    using System;

    public class Card
    {
        public string Description => $"{_rank.GetShortRank()}{_suite.GetShortName()}";

        public bool Hidden { get; set; }

        private readonly Rank _rank;

        private readonly Suite _suite;

        private readonly int _points;

        public Card()
        {
            Rank rank = new Rank();
            _rank = rank;
            Suite suite = new Suite();
            _suite = suite;
            /* _points = points;

             this.Hidden = hidden; */
        }

        public void MakeCard()
        {
            
        }
    
    }
}
