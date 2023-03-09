using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        private List<Card> pack;

        public Pack()
        {
            //Initialise the card pack here
            pack = new List<Card>();
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] values = { "Ace", "2", "3", "4", "5", "6", "7", "8","9", "10", "Jack", "Queen", "King" };
            foreach (string suit in suits)
            {
                foreach(string value in values)
                {
                    pack.Add(new Card(suit, value));
                }
            }
        }

        public bool shuffleCardPack(int typeOfShuffle)
        {
            // Shuffles the pack based on the type of shuffle
            // Returns true if shuffle was successful, false otherwise

            switch (typeOfShuffle)
            {
                case 1:
                    return FisherYatesShuffle();
                case 2:
                    return RiffleShuffle();
                case 3:
                    return true;
                default:
                    return false;
            }
        }

        private bool FisherYatesShuffle()
        {
            // Performs a Fisher-Yates shuffle on the pack
            Random random = new Random();
            int n = pack.Count;
            for (int i = n - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                Card temp = pack[j];
                pack[j] = pack[i];
                pack[i] = temp;
            }
            return true;
        }

        private bool RiffleShuffle()
        {
            // Performs a riffle shuffle on the pack
            // TODO: Implement riffle shuffle
            return false;
        }

        public Card deal()
        {
            // Deals one card from the pack
            // Returns the dealt card
            if (pack.Count == 0)
            {
                throw new Exception("The pack is empty.");
            }

            Card dealtCard = pack[0];
            pack.RemoveAt(0);

            return dealtCard;
        }

        public List<Card> dealCard(int amount)
        {
            // Deals the number of cards specified by 'amount'
            // Returns a list of the dealt cards
            if (pack.Count < amount)
            {
                throw new Exception("Not enough cards in the pack.");
            }

            List<Card> dealtCards = new List<Card>();
            for (int i = 0; i < amount; i++)
            {
                dealtCards.Add(deal());
            }

            return dealtCards;
        }
    }
}