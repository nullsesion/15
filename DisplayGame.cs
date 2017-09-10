using System;
namespace _15
{
	class DisplayGame : IDisposable
	{
		public void Display(StateGame state)
		{
			int[,] s = state.GetState();
			Console.Clear();
			Console.CursorVisible = false;
			for (int i = 0; i < s.GetLength(0); i++)
				for (int j = 0; j < s.GetLength(1); j++)
					ShowCell(s[i, j], j, i);
			
			//Console.ReadKey();
		}

	    public Command GetCommand()
	    {
	        ConsoleKeyInfo cki = Console.ReadKey();

	        if (cki.Key == ConsoleKey.Escape)
	            return Command.Escape;

	        if (cki.Key == ConsoleKey.UpArrow)
	            return Command.Up;

	        if (cki.Key == ConsoleKey.RightArrow)
	            return Command.Right;

	        if (cki.Key == ConsoleKey.DownArrow)
	            return Command.Down;

	        if (cki.Key == ConsoleKey.LeftArrow)
	            return Command.Left;

            return Command.Empty;
        }

	    public static void ErrorMessage()
	    {
	        Console.Beep();
	    }

	    private void ShowCell(int cellValue, int x, int y)
		{
			const int sizeX = 5;
			const int sizeY = 5;

			int xPos = x * sizeX;
			int yPos = y * sizeY;
			Console.SetCursorPosition(yPos, xPos);
			for (int i = 0; i < sizeX; i++)
			{
				for (int j = 0; j < sizeY; j++)
				{
					Console.SetCursorPosition(xPos, yPos);
					if (i == 0 && j == 0 )
						Console.Write("+");
					else if (i == (sizeX - 1) && j == (sizeY - 1))
						Console.Write("+");
					else if (i == 0 && j == (sizeY - 1))
						Console.Write("+");
					else if (i == (sizeX - 1) && j == 0)
						Console.Write("+");
					else if (i == 0 && (j > 0 && j < (sizeY - 1)))
						Console.Write("|");
					else if (i == (sizeX - 1) && (j > 0 && j < (sizeY - 1)))
						Console.Write("|");
					else if (j == 0 && (i > 0 && i < (sizeX - 1)))
						Console.Write("-");
					else if (j == (sizeY - 1) && (i > 0 && i < (sizeX - 1)))
						Console.Write("-");

					if(i == 2 && j == 2)
						Console.Write(cellValue);
					yPos++;
				}
				yPos = y * sizeY;
				xPos++;
			}
		}

	    public void Dispose()
	    {
	    }
    }
}
