using Chapter._9;
using NUnit.Framework;

namespace LegacyCode.Tests.Chapter._9
{
	[TestFixture]
	class CreditValidatorTests
	{
		private Certificate _result;

		[SetUp]
		public void Init()
		{
			CreditMaster master = new CreditMaster("crm2.mas", true);
			IRGHConnection connection = new FakeConnection();
			CreditValidator validator = new CreditValidator(connection, master, "a");
			connection.Report = new RFDIReport();

			_result = validator.ValidateCustomer(new Customer());
		}

		[Test]
		public void testNoSuccess()
		{
			Assert.AreEqual(Certificate.Valid, _result.GetStatus());

		}

	}
}
