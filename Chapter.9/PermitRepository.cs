using System;
using System.Globalization;

namespace Chapter._9
{
	public class PermitRepository
	{
		private static PermitRepository _instance = null;

		protected PermitRepository()
		{

		}

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

		public int Id()
		{
			return 10;
		}

		public static void SetTestingInstance(PermitRepository instance)
		{
			_instance = instance;
		}
	}
}