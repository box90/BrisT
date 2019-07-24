using System.Collections.Generic;
using System.Linq;

namespace BrisT.Deck
{
    public class Hand : BrisT.Interfaces.IHand
    {
        private List<Card> cards {get;}

        public Hand(List<Card> c)
        {
            this.cards = c;
        } 

        public List<Card> GetHand()
        {
           return cards;
        }

        public Card PlayCard(int v)
        {
            Card playerdCard = cards.Where(c => c.CardValue() == v).FirstOrDefault();

            //TODO - verifica esistenza carta qui o a valle
            cards.Remove(playerdCard);
            return playerdCard;
        }
    }
}