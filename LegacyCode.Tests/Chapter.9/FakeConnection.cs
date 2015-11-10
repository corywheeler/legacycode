using Chapter._9;

namespace LegacyCode.Tests.Chapter._9
{
	class FakeConnection : IRGHConnection
	{
		private readonly string _password;
		private readonly string _admin;

		public FakeConnection(string admin, string password)
		{
			_admin = admin;
			_password = password;
		}


		public RFDIReport Report { get; set; }

		public void Connect()
		{
		}

		public void DisConnect()
		{
		}

		public RFDIReport RFDIReportFor(int id)
		{
			return Report;
		}

		public ACTIOReport ACTIOReportFor(int customerID)
		{
			return null;
		}

	}
}
