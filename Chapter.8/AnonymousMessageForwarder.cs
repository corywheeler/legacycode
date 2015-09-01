using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter._8
{
	public class AnonymousMessageForwarder: MessageForwarder
	{
		private readonly string _listAddress;
		public AnonymousMessageForwarder(string domain, string listAddress) : base(domain)
		{
			_listAddress = listAddress;
		}

		protected override InternetAddress GetFromAddress(Message message)
		{
			string anonymousAddress = "anon-" + _listAddress + "@" + GetDomain();
			return new InternetAddress(anonymousAddress);
		}
	}
}
