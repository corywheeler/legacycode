using Chapter._8;
using Chapter._8.Exceptions;
using NUnit.Framework;

namespace LegacyCode.Tests.Chapter._8
{
	[TestFixture]
	public class MessageForwarderTests
	{
		private Message _expectedMessage;

		[SetUp]
		public void Init()
		{
			_expectedMessage = MakeFakeMessage();
		}

		[Test]
		public void testAnonymous()
		{
			MessageForwarder forwarder = new MessageForwarder();
			forwarder.ForwardMessage(MakeFakeMessage());

			Assert.AreEqual("anon-members@" + forwarder.GetDomain(), _expectedMessage.GetFrom().GetValue(0).ToString());
		}

		private Message MakeFakeMessage()
		{
			return new Message(new Address("cory@shoptotrot.com"));
		}
	}
}
