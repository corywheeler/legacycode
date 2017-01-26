using Chapter._9;
using NUnit.Framework;

namespace LegacyCode.Tests.Chapter._9
{
	[TestFixture]
	class CreditValidatorTests
	{
		private Certificate _result;
		private CreditValidator _validator;

		[SetUp]
		public void Init()
		{
			var master = new CreditMaster("crm2.mas", true);
			IRGHConnection connection = new FakeConnection("admin", "rii8ii9s");
			_validator = new CreditValidator(connection, master, "a");
			connection.Report = new RFDIReport();

			_result = _validator.ValidateCustomer(new Customer());
		}

		[Test]
		public void testNoSuccess()
		{
			Assert.AreEqual(Certificate.Valid, _result.GetStatus());

		}

		[Test]
		public void testAllPassed100Percent()
		{
			const double THRESHOLD = 0.0;
			Assert.AreEqual(100.0, _validator.GetValidationPercent(), THRESHOLD);
		}
	}
}
