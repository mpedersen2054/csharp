using System;

namespace CardGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Deck deck = new Deck();
            Player p1 = new Player("Matt");
            Player p2 = new Player("Enemy");

            p1.drawCard(deck);
            p1.drawCard(deck);
            p2.drawCard(deck);
            p2.drawCard(deck);

            p1.peekHand();
            p1.discardCard(3);
            p1.peekHand();
        }
    }
}
