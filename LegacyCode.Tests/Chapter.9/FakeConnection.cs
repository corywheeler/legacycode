using Chapter._9;

namespace LegacyCode.Tests.Chapter._9
{
	class FakeConnection : IRGHConnection
	{


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
