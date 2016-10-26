using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackWS3.model.rules
{
    class RulesFactory
    {
        public IHitStrategy GetHitRule()
        {
            return new BasicHitStrategy();
        }

        public INewGameStrategy GetNewGameRule()
        {
            return new AmericanNewGameStrategy();
        }
    }
}
