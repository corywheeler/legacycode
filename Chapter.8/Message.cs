namespace Chapter._8
{
	public class Message
	{
		private Address[] _getFrom;

		public Message(Address fromAddress)
		{
			_getFrom = new[] { fromAddress };
		}

		public Address[] GetFrom()
		{
			return _getFrom;
		}
	}
}