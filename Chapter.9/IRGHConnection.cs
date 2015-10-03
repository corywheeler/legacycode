namespace Chapter._9
{
	public interface IRGHConnection
	{
		void Connect();
		void DisConnect();
		RFDIReport RFDIReportFor(int id);
		ACTIOReport ACTIOReportFor(int customerID);
		RFDIReport Report { get; set; }
	}
}