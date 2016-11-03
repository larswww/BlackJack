using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackWS3.model.rules
{
    class OriginalWinStrategy : IWinStrategy
    {

        public bool isDealerWinner(Player a_player, Dealer a_dealer, int g_maxScore) {

            if (a_player.CalcScore() > g_maxScore)
            {
                return true;
            }
            else if (a_dealer.CalcScore() > g_maxScore)
            {
                return false;
            }
            return a_dealer.CalcScore() >= a_player.CalcScore();

        }

    }
}
