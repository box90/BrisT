using System;
using System.Collections.Generic;

namespace BrisT.Deck
{
    public class Deck
    {
        //♠ ♥ ♦ ♣
        private const int CARD_MAX = 10;
        
        private List<Card> cards;

        public Deck()
        {
            List<string> setsUNICODE = new List<string>{"♠","♥","♦", "♣"};
            List<string> sets = new List<string>{"P","C","Q","F"}; 
            cards = new List<Card>();

            for (int i = 1; i <= CARD_MAX; i++)
            {
                foreach (string set in sets)
                {
                    cards.Add(new Card(set,i));
                }
            }
        }

        public void PrintDeck()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card.CardName());
            }
        }
    }
}