using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackWS3.model.rules
{
    class Soft17GameStrategy : IHitStrategy
    {
        private const int g_hitLimit = 17;

        public bool DoHit(model.Player a_dealer)
        {

            if (a_dealer.CalcScore() == 17 && a_dealer.hasAce())
            {
                return true;
            }

            return a_dealer.CalcScore() < g_hitLimit;

        }

    }
}


