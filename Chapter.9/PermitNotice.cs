namespace Chapter._9
{
	public class PermitNotice
	{
		public int PermitCode { get; private set; }
		public string Owner { get; private set; }

		public PermitNotice(int permitCode, string owner)
		{
			PermitCode = permitCode;
			Owner = owner;
		}

		public bool IsValid()
		{
			return false;
		}
	}
}