﻿namespace Chapter._9.Unmodified
{
	public class Certificate
	{
		private readonly int _defaultStatus = 10;
		public Certificate()
		{
			Valid = _defaultStatus;
		}
	
		public int Valid { get; private set; }

		public int GetStatus()
		{
			return _defaultStatus;
		}

	}
}
