namespace Chapter._9.Unmodified
{
	public class PermitRepository
	{
		private static PermitRepository _instance = null;

		private PermitRepository() { }

		public static PermitRepository GetInstance()
		{
			if (_instance == null)
			{
				_instance = new PermitRepository();
			}

			return _instance;
		}

		public Permit FindAssociatedPermit(PermitNotice notice)
		{
			// open permit database
			// ...

			// select using values in notice
			// ...

			// verify we have only one matching permit, it not report error
			// ...

			// return the matching permit
			// ...

			return new Permit(notice);
		}
	}
}