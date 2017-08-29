using System;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
        	Game game = new Game();
			StateGame state = game.GetStateGame();
			DisplayGame show = new DisplayGame();
			show.Display(state);
        }
    }
}
