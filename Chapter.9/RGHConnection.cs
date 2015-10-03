namespace Chapter._9
{
	public class RGHConnection
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
	}
}