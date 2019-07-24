using System.Collections.Generic;
using BrisT.Deck;

namespace BrisT.Table
{
    public class TableManager
    {
        public const int MAX_PLAYERS = 5;
        
        public List<BrisT.Player.Player> players  {get;set;}
        public Hand CurrentHand { get; set; }

    }
}