namespace Blackjack.Client.Console
{
    using System;
    using System.Collections.Generic;

    using Blackjack.Core;

    public class Program
    {
        // All aces are 11 points. In real life, one can choose whether it is 1 or 11
        // When user draws a card, house always draws one as-well. In real life, house can decide based on some rules...  

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game of Blackjack!");
            Console.WriteLine();

            var cards = new List<Card>
                            {
                                new Card(Rank.Four, Suite.Club, 4, false),
                                new Card(Rank.Six, Suite.Heart, 6, false),
                                new Card(Rank.Eight, Suite.Spade, 8, false),
                                new Card(Rank.Jack, Suite.Diamond, 10, true),
                                new Card(Rank.Four, Suite.Spade, 4, false),
                                new Card(Rank.Ten, Suite.Heart, 10, true)
                            };

            var deck = new Deck(cards);

            Console.WriteLine($"You have been dealt: {GetCardDescription(deck.Next())}, {GetCardDescription(deck.Next())}");
            Console.WriteLine($"House has been dealt: {GetCardDescription(deck.Next())}, { GetCardDescription(deck.Next())}");
            Console.WriteLine();

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Choose: 1 - To take another card");
            Console.WriteLine("Choose: 2 - To finish");
            Console.WriteLine();
            Console.WriteLine("I choose: 1");
            Console.WriteLine();

            Console.WriteLine($"You have been dealt: {GetCardDescription(deck.Next())}");
            Console.WriteLine($"House has been dealt: {GetCardDescription(deck.Next())}");
            Console.WriteLine();

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Choose: 1 - To take another card");
            Console.WriteLine("Choose: 2 - To finish");
            Console.WriteLine();
            Console.WriteLine("I choose: 2");
            Console.WriteLine();

            Console.WriteLine("You have 14 points vs. house 17 points");
            Console.WriteLine("House wins!");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        public static string GetCardDescription(Card card)
        {
            return card.Hidden ? "[?]" : card.Description;
        }
    }
}
