using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        private string value;

        // Properties for the value and suit of the card
        public int Value { get; set; }
        public string Suit { get; set; }

        // Constructor for creating a new card with a given value and suit
        public Card(string suit, int value)
        {
            Suit = suit;
            Value = value;
        }

        public Card(string suit, string value)
        {
            Suit = suit;
            this.value = value;
        }

        // Override ToString method to return a string representation of the card
        public override string ToString()
        {
            string valueStr;
            switch (Value)
            {
                case 1:
                    valueStr = "Ace";
                    break;
                case 11:
                    valueStr = "Jack";
                    break;
                case 12:
                    valueStr = "Queen";
                    break;
                case 13:
                    valueStr = "King";
                    break;
                default:
                    valueStr = Value.ToString();
                    break;
            }
            return valueStr + " of " + Suit;
        }
    }
}
