namespace Chapter._9
{
	public class Facility
	{
		protected Permit _basePermit;
		private static int _residence = 1;

		public Facility()
		{
		}

		public Facility(int facilityCode, string owner, PermitNotice notice)
		{
			Permit associatedPermit = PermitRepository.GetInstance().FindAssociatedPermit(notice);
			Permit permit = null;

			if (associatedPermit.IsValid() && !notice.IsValid())
			{
				_basePermit = associatedPermit;
			}
			else if (!notice.IsValid())
			{
				permit = new Permit(notice);
				permit.Validate();
				_basePermit = permit;
			}
			else
			{
				throw new PermitViolation(permit);
			}


		}

		public static int Residence
		{
			get { return _residence; }
			private set { _residence = value; }
		}
	}
}
