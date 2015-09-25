using System;
using System.Linq;

namespace Chapter._8
{
	public class MessageForwarder
	{
		private readonly Properties _configuration;
		private string _domain;

		public MessageForwarder(Properties configuration, string domain)
		{
			_configuration = configuration;
			_domain = domain;
		}

		public InternetAddress GetFromAddress(Message message)
		{
			string fromAddress = GetDefaultFrom();

			if (_configuration.GetProperty("anonymous") == "true")
			{
				fromAddress = FromAddress();
			}
			else
			{
				fromAddress = GetFrom(message);
			}

			return new InternetAddress(fromAddress);
		}

		private static string GetFrom(Message message)
		{
			Address[] from = message.GetFrom();
			var fromAddress = string.Empty;

			if (@from != null && @from.Any())
			{
				fromAddress = @from.GetValue(0).ToString();
			}
			return fromAddress;
		}

		private string FromAddress()
		{
			return "anon-members@" + _domain;
		}

		public void ForwardMessage(Message message)
		{
			string session = String.Empty;
			MimeMessage forward = new MimeMessage(session);
			forward.SetFrom(GetFromAddress(message));
			forward.Send();
		}

		public void ProcessMessage(Message message)
		{
			// Do some work.
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
