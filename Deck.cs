using System;
using System.Collections.Generic;

namespace DeckofCards
{
    public class Deck
    {
        public List<Card> cards;
        private static Random rand = new Random();

        public Deck()
        {
            Reset();
        }

        public void Reset()
        {
            cards = new List<Card>();
            string[] suits = {"Diamonds", "Hearts", "Clubs", "Spades"};
            string[] values = {"Ace", "King", "Queen", "Jack", "10", "9", "8", "7", "6", "5", "4", "3", "2"};
            foreach(string suit in suits)
            {
                foreach(string value in values)
                {
                    cards.Add(new Card(value, suit));
                }
            }
        }

        public Card Deal()
        {
            Card cardToReturn = cards[0];
            cards.RemoveAt(0);
            return cardToReturn;
        }

        public void Shuffle()
        {
            for(int i=0; i<cards.Count; i++)
            {
                int randIndex = rand.Next(cards.Count);
                Card temp = cards[0];
                cards[0] = cards[randIndex];
                cards[randIndex] = temp;
            }
        }

    }
}