using System;
using System.Collections.Generic;

namespace CardGame
{
    public class Deck
    {
        private Random random = new Random();
        public List<Card> cards;

        public Deck()
        {
            reset();
        }

        public Card takeCard()
        {
            Card card = cards[cards.Count - 1];
            cards.RemoveAt(cards.Count - 1);
            return card;
        }

        public void shuffle()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                int pos = random.Next(cards.Count);
                Card temp = cards[i];
                cards[i] = cards[pos];
                cards[pos] = temp;
            }
        }

        public void reset()
        {
            string[] suites = { "Diamonds", "Hearts", "Spades", "Clubs" };
            cards = new List<Card>();

            foreach (string suite in suites)
            {
                for (int i = 1; i < 14; i++)
                {
                    cards.Add(new Card(i, suite));
                }
            }
            // add/remove as many shuffles as needed
            shuffle();shuffle();shuffle();
        }
    }
}