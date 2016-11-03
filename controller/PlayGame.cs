using BlackJack2.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackWS3.controller
{
    class PlayGame : GameObserver
    {
        private view.IView m_view;
        private model.Game m_game;

        public PlayGame(view.IView a_view, model.Game a_model)
        {
            m_view = a_view;
            m_game = a_model;
            m_game.SetSubscriber(this);
        }

        public bool Play()
        {
            DisplayWelcomeMessageAndHands();
                
            if (m_game.IsGameOver())
            {
                m_view.DisplayGameOver(m_game.IsDealerWinner());
            }

            ViewAction action = m_view.GetAction();

            if (action == ViewAction.Newgame)
            {
                m_game.NewGame();
            }
            else if (action == ViewAction.Hit)
            {
                m_game.Hit();
            }
            else if (action == ViewAction.Stand)
            {
                m_game.Stand();
            }

            return action != ViewAction.Quit;
        }

        public void tempGamePause()
        {
            System.Threading.Thread.Sleep(1000);
            DisplayWelcomeMessageAndHands();
        }


        public void DisplayWelcomeMessageAndHands()
        {

            m_view.DisplayWelcomeMessage();

            m_view.DisplayDealerHand(m_game.GetDealerHand(), m_game.GetDealerScore());
            m_view.DisplayPlayerHand(m_game.GetPlayerHand(), m_game.GetPlayerScore());

        }

    }
}
