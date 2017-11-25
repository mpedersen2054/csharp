using System;
using System.Collections.Generic;

namespace CardGame
{
    public class Player
    {
        public string name;
        public List<Card> hand;

        public Player(string givenName)
        {
            name = givenName;
            hand = new List<Card>();
        }

        // accepts Deck, calls Deck.takeCard(), adds it to players hand
        public Card drawCard(Deck deck)
        {
            Card card = deck.takeCard();
            hand.Add(card);
            return card;
        }

        // show the cards in the players hand
        public void peekHand()
        {
            foreach (Card card in hand)
            {
                System.Console.WriteLine($"{card.fullStringVal}");
            }
        }

        // should remove the card if it exists, or return null if no card at idx
        // need to figure out more about handling the errors
        public object discardCard(int idx)
        {
            Card card = hand[idx];
            if (hand.Count < idx && hand[idx] != null)
            {
                hand.RemoveAt(idx);
                return card;
            }
            else
            {
                return null;
            }
        }
    }
}