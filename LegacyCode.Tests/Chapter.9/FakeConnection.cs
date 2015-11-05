using Chapter._9;

namespace LegacyCode.Tests.Chapter._9
{
	class FakeConnection : IRGHConnection
	{


		public RFDIReport Report { get; set; }

		public void Connect()
		{
			throw new System.NotImplementedException();
		}

		public void DisConnect()
		{
			throw new System.NotImplementedException();
		}

		public RFDIReport RFDIReportFor(int id)
		{
			throw new System.NotImplementedException();
		}

		public ACTIOReport ACTIOReportFor(int customerID)
		{
			throw new System.NotImplementedException();
		}

	}
}
