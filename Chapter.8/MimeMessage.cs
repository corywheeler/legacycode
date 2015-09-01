namespace Chapter._8
{
	public class MimeMessage
	{
		private InternetAddress _getFromAddress;

		public MimeMessage(string session)
		{
		}

		public void SetFrom(InternetAddress getFromAddress)
		{
			_getFromAddress = getFromAddress;
		}

		public InternetAddress GetFrom()
		{
			return _getFromAddress;
		}

		public void Send()
		{
			
		}
	}
}