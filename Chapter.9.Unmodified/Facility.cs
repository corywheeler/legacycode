namespace Chapter._9.Unmodified
{
	public class Facility
	{
		private Permit _basePermit;

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

	}
}
