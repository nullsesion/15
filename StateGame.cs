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
			if (_x == 0)
				return false;
			return true;
		}
        
		public bool IsDown()
		{
			if (_x == (size - 1))
				return false;
			return true;
		}

		public bool IsLeft()
		{
			if (_y == 0)
				return false;
			return true;
		}

		public bool isRight()
		{
			if (_y == (size - 1))
				return false;
			return true;
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

	    public void Swap(int offsetY, int offsetX)
	    {
	        int tmp = State[_x, _y];
	        State[_x, _y] = State[_x + offsetX, _y + offsetY];
	        State[_x + offsetX, _y + offsetY] = tmp;

	        _x = _x + offsetX;
	        _y = _y + offsetY;
	    }


        public int[,] GetState()
		{
			return State;
		}
	}
}