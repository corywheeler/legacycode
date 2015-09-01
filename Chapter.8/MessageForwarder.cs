using System;
using System.Linq;

namespace Chapter._8
{
	public class MessageForwarder
	{
		private string _domain;

		public MessageForwarder(string domain)
		{
			_domain = domain;
		}

		protected virtual InternetAddress GetFromAddress(Message message)
		{
			Address[] from = message.GetFrom();
			if (from != null && from.Any())
			{
				return new InternetAddress(from.GetValue(0).ToString());
			}

			return new InternetAddress(GetDefaultFrom());
		}

		public void ForwardMessage(Message message)
		{
			string session = String.Empty;
			MimeMessage forward = new MimeMessage(session);
			forward.SetFrom(GetFromAddress(message));
			forward.Send();
		}
		
		private string GetDefaultFrom()
		{
			return string.Empty;
		}

		

		public string GetDomain()
		{
			return _domain;
		}
	}
}
