using System;
using System.Collections.Generic;
using System.Text;

namespace _15
{
    class GameControl
    {
        private static GameControl instance;
        private GameControl()
        {}

        public static GameControl GetInstance()
        {
            if (instance == null)
                instance = new GameControl();
            return instance;
        }

        public void loopKeyPress(Game game)
        {
            bool programExit = true;
            do
            {
                DisplayGame show = new DisplayGame();

                Command command = show.GetCommand();
                
                if (command == Command.Escape)
                    programExit = false;

                if (command == Command.Up)
                {
                    game.ActionUp();
                    show.Display(game.GetStateGame());
                }

                if (command == Command.Right)
                {
                    game.ActionRight();
                    show.Display(game.GetStateGame());
                }

                if (command == Command.Down)
                {
                    game.ActionDown();
                    show.Display(game.GetStateGame());
                }

                if (command == Command.Left)
                {
                    game.ActionLeft();
                    show.Display(game.GetStateGame());
                }


            } while (programExit);
        }
    }
}
