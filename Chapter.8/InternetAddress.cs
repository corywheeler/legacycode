namespace Chapter._8
{
	public class InternetAddress
	{
		private readonly string _address;

		public InternetAddress(string address)
		{
			_address = address;
		}

		public string GetAddress()
		{
			return _address;
		}
	}
}