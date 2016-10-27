using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackWS3.model.rules
{
    class AmericanNewGameStrategy : INewGameStrategy
    {
        public bool NewGame(Deck a_deck, Dealer a_dealer, Player a_player)
        {
            a_dealer.GiveCardToPlayer(a_player, true);
            a_dealer.GiveCardToPlayer(a_dealer, true);
            a_dealer.GiveCardToPlayer(a_player, true);
            a_dealer.GiveCardToPlayer(a_dealer, false);

            return true;
        }
    }
}
