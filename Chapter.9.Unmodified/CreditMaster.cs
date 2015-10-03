namespace Chapter._9.Unmodified
{
	public class CreditMaster
	{
		private readonly string _filename;
		private readonly bool _isLocal;

		public CreditMaster(string filename, bool isLocal)
		{
			_filename = filename;
			_isLocal = isLocal;
		}
	}
}