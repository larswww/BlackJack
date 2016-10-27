using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackWS3.model.rules
{
    interface IWinStrategy
    {
        bool isDealerWinner(Player a_player, Dealer a_dealer);
    }
}
