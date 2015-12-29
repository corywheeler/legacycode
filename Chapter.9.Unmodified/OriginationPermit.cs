namespace Chapter._9.Unmodified
{
	public class OriginationPermit : FacilityPermit
	{

		public OriginationPermit(PermitNotice permitNotice) : base(permitNotice)
		{

		}

		public new void Validate()
		{
			// form connection to database

			// query for validation information

			// set the validation flag

			// close database
		}
	}
}