using BlackJack2.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackWS3.controller
{
    class PlayGame
    {
        public bool Play(model.Game a_game, view.IView a_view)
        {
            a_view.DisplayWelcomeMessage();

            a_view.DisplayDealerHand(a_game.GetDealerHand(), a_game.GetDealerScore());
            a_view.DisplayPlayerHand(a_game.GetPlayerHand(), a_game.GetPlayerScore());

            if (a_game.IsGameOver())
            {
                a_view.DisplayGameOver(a_game.IsDealerWinner());
            }

            ViewAction action = a_view.GetAction();

            if (action == ViewAction.Newgame)
            {
                a_game.NewGame();
            }
            else if (action == ViewAction.Hit)
            {
                a_game.Hit();
            }
            else if (action == ViewAction.Stand)
            {
                a_game.Stand();
            }

            return action != ViewAction.Quit;
        }
    }
}
