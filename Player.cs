using System;
using System.Collections.Generic;

namespace DeckofCards
{
    public class Player
    {
        string name; 
        public List<Card> hand = new List<Card>();
        public Player(string name)
        {
            this.name = name;
        }
        public void Draw(Deck deck)
        {
            hand.Add(deck.Deal());
        }
        public Card Discard(int index)
        {
            if (hand.Count > index)
            {
                Card discarded = hand[index];
                hand.RemoveAt(index);
                return discarded;
            }
            return null;
        }

    }
}