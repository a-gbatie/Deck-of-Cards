using System;

namespace DeckofCards
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Deck d1 = new Deck();
            d1.Shuffle();
            // d1.Deal().Display();
            // d1.Deal().Display();
            // Console.WriteLine(d1.cards.Count);
            // d1.Reset();
            Player p1 = new Player("Bob");
            p1.Draw(d1);
            p1.Draw(d1);
            p1.Draw(d1);
            p1.Draw(d1);
            p1.Draw(d1);
            foreach(Card c in p1.hand){
                c.Display();
            }
            Console.WriteLine(d1.cards.Count);
            p1.Discard(4);
            foreach(Card c in p1.hand){
                c.Display();
            }
        }
    }
}
