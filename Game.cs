using System;

namespace _15
{
	class Game
	{
		private StateGame state;

		public StateGame GetStateGame()
		{
			return state;
		}
		public Game(int size = 4)
		{
			state = new StateGame(size);
			state.InitState();
		}

		public void ActionUp()
		{
			if (state.IsUp())
			{
				
			}
			throw new NotImplementedException();
		}
		public void ActionDown()
		{
			if (state.IsUp())
			{

			}
			throw new NotImplementedException();
		}
		public void ActionLeft()
		{
			if (state.IsLeft())
			{

			}
			throw new NotImplementedException();
		}
		public void ActionRight()
		{
			if (state.isRight())
			{

			}
			throw new NotImplementedException();
		}

		private Tuple<int, int> FindNull()
		{
			int[,] s = state.GetState();
			for (int i = 0; i < s.GetLength(0); i++)
				for (int j = 0; j < s.GetLength(1); j++)
					if (s[i,j] == 0)
						return new Tuple<int, int>(i, j);
						
					
			throw new NotImplementedException();
		}
	}
}
