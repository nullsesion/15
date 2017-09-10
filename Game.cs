using System;
using System.Collections.Generic;
using System.Linq;

namespace _15
{
	class Game
	{
	    private List<StateGame> historyStateGames;
		private StateGame state;

		public StateGame GetStateGame()
		{
			return state;
		}
		public Game(int size = 4)
		{
			state = new StateGame(size);
		    //historyStateGames.Add(state);

            state.InitState();
		}

		public void ActionUp()
		{
		    if (state.IsUp())
		    {
		        state.Swap(0, -1);
		        //historyStateGames.Add(state);
		    }
		    else
		    {
                DisplayGame.ErrorMessage();
            }
        }
        public void ActionDown()
		{
		    if (state.IsDown())
		    {
		        state.Swap(0, 1);
		        //historyStateGames.Add(state);
		    }
		    else
		    {
		        DisplayGame.ErrorMessage();
            }
        }
        public void ActionLeft()
		{
		    if (state.IsLeft())
		    {
		        state.Swap(-1, 0);
		        //historyStateGames.Add(state);
		    }
		    else
		    {
		        DisplayGame.ErrorMessage();
            }
        }
        public void ActionRight()
		{
		    if (state.isRight())
		    {
		        state.Swap(1, 0);
		        //historyStateGames.Add(state);
		    }
		    else
		    {
		        DisplayGame.ErrorMessage();
            }
		}
	}
}
