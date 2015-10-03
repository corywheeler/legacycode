namespace Chapter._9
{
	public class RGHConnection : IRGHConnection
	{
		private readonly int _port;
		private readonly string _name;
		private readonly string _passwd;

		public RGHConnection(int port, string name, string passwd)
		{
			_port = port;
			_name = name;
			_passwd = passwd;
		}

		public void Connect()
		{
			
		}

		public void DisConnect()
		{
			
		}

		public RFDIReport RFDIReportFor(int id)
		{
			return new RFDIReport();
		}

		public ACTIOReport ACTIOReportFor(int customerID)
		{
			return new ACTIOReport();
		}

		public RFDIReport Report { get; set; }
	}
}