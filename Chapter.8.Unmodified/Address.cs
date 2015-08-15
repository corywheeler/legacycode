namespace Chapter._8
{
	public class Address
	{
		private readonly string _emailAddress;

		public Address(string emailAddress)
		{
			_emailAddress = emailAddress;
		}

		public override string ToString()
		{
			return _emailAddress;
		}
	}
}