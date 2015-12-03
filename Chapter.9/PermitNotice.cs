namespace Chapter._9
{
	public class PermitNotice
	{
		private readonly int _permitCode;
		private readonly string _owner;

		public PermitNotice(int permitCode, string owner)
		{
			_permitCode = permitCode;
			_owner = owner;
		}

		public bool IsValid()
		{
			return false;
		}
	}
}