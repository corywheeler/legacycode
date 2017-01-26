using System;
using Chapter._8;
using NUnit.Framework;

namespace LegacyCode.Tests.Chapter._8
{
	[TestFixture]
	public class MessageForwarderTests
	{
		private Message _expectedMessage;
		private string _listAddress;
		private string _domain;

		[SetUp]
		public void Init()
		{
			_expectedMessage = new Message(new Address("anon-shoppers@shoptotrot.com"));
		}

		[Test]
		public void testAnonymous()
		{
			_domain = "shoptotrot.com";
			_listAddress = "shoppers";

			var configuration = new Properties();
			var forwarder = new MessageForwarder(configuration, _domain);
			forwarder.ForwardMessage(MakeFakeMessage());
			Console.WriteLine(forwarder.GetDomain());
			Console.WriteLine(_expectedMessage.GetFrom().GetValue(0));

			Assert.AreEqual(_expectedMessage.GetFrom().GetValue(0).ToString(), "anon-" + _listAddress + "@" + forwarder.GetDomain());
		}

		private Message MakeFakeMessage()
		{
			return new Message(new Address("nobody@gmail.com"));
		}
	}
}