using System;
using BrisT.Deck;

namespace BrisT
{
    class Program
    {
        static void Main(string[] args)
        {
            BrisT.Deck.Deck d = new BrisT.Deck.Deck();
            d.PrintDeck();

            Console.ReadLine();
        }
    }
}
