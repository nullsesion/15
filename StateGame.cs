namespace _15
{
	public class StateGame
	{
		private int[,] State { get; set; }

		int _x;
		int _y;

		private int size;
		public StateGame(int size)
		{
			this.size = size;
		}

		public bool IsUp()
		{
			if (_y == 0)
				return true;
			return false;
		}

		public bool IsDown()
		{
			if (_y == (size - 1))
				return true;
			return false;
		}

		public bool IsLeft()
		{
			if (_x == 0)
				return true;
			return false;
		}

		public bool isRight()
		{
			if (_x == (size - 1))
				return true;
			return false;
		}

		public void InitState()
		{
			State = new int[size, size];

			int number = 1;
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					State[i, j] = number;
					number++;
				}
			}

			_x = size - 1;
			_y = size - 1;

			State[_x, _y] = 0;
		}

		public int[,] GetState()
		{
			return State;
		}
	}
}
//http://kinogo-2016.net/4457-12.html