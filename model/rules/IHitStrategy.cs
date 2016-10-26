using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackWS3.model.rules
{
    interface IHitStrategy
    {
        bool DoHit(model.Player a_dealer);
    }
}
