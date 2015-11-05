namespace Chapter._9
{
	public interface IRGHConnection
	{
		RFDIReport Report { get; set; }

		void Connect();
		void DisConnect();
		ACTIOReport ACTIOReportFor(int customerID);
		RFDIReport RFDIReportFor(int id);
	}
}