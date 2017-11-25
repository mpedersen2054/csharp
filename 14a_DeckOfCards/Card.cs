
namespace CardGame
{
    public class Card
    {
        public int val;
        public string stringVal;
        public string suite;
        public string fullStringVal;

        public Card(int cardVal, string cardSuite)
        {
            val = cardVal;
            suite = cardSuite;
            // assign stringVal for royal cards
            if (val == 1)
            {
                // might have to change the val for ace
                stringVal = "Ace";
            }
            else if (val == 11)
            {
                stringVal = "Jack";
            }
            else if (val == 12)
            {
                stringVal = "Queen";
            }
            else if (val == 13)
            {
                stringVal = "King";
            }
            else
            {
                stringVal = cardVal.ToString();
            }

            fullStringVal = $"{stringVal} of {suite}";
        }
    }
}