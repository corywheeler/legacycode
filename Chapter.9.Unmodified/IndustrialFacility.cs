namespace Chapter._9.Unmodified
{
	public class IndustrialFacility : Facility
	{
		public IndustrialFacility(int facilityCode, string owner, OriginationPermit permit)
		{
			Permit associatedPermit = PermitRepository.GetInstance().FindAssociatedFromOrigination(permit);

			if (associatedPermit.IsValid() && !permit.IsValid())
			{
				_basePermit = associatedPermit;
			} 
			else if (!permit.IsValid())
			{
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
