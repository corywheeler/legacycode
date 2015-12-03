using System.Collections.Generic;
using Chapter._9;

namespace LegacyCode.Tests.Chapter._9
{
	public class TestingPermitRepository : PermitRepository
	{
		private Dictionary<PermitNotice, Permit> _permits = new Dictionary<PermitNotice, Permit>();

		public void AddAssociatedPermit(PermitNotice notice, Permit permit)
		{
			_permits.Add(notice, permit);
		}

		public new Permit FindAssociatedPermit(PermitNotice notice)
		{
			Permit foundPermit;
			_permits.TryGetValue(notice, out foundPermit);
			return foundPermit;
		}

		public new int Id()
		{
			return 20;
		}
	}
}