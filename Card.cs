using System;
using System.Collections.Generic;

namespace DeckofCards
{
    public class Card
    {
        public string val;
        public string suit;
        
        public Card(string val, string suit)
        {
            this.val = val;
            this.suit = suit;
        }

        public void Display()
        {
            Console.WriteLine($"{val} of {suit}");
        }
    }
}