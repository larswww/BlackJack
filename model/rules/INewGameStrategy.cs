using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackWS3.model.rules
{
    interface INewGameStrategy
    {
        bool NewGame(Deck a_deck, Dealer a_dealer, Player a_player);
    }
}
