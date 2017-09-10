using System;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
        	Game game = new Game();
			StateGame state = game.GetStateGame();

            //первый показ поля игры
            DisplayGame show = new DisplayGame();
            using (show)
            {
                show.Display(state);
            }
			
            GameControl
                .GetInstance()
                .loopKeyPress(game);


        }
    }
}
