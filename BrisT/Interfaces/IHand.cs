using System.Collections.Generic;
using BrisT.Deck;

namespace BrisT.Interfaces
{
    public interface IHand
    {
         List<Card> GetHand();

         Card PlayCard(int v);

    }
}