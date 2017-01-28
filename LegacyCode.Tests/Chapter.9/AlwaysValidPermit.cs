using LegacyCode.Tests.Chapter._9;
using Chapter._9;

namespace LegacyCode.Tests
{
	public class AlwaysValidPermit : FakeOriginationPermit
	{
		public AlwaysValidPermit() : this(null)
		{
		}

		public AlwaysValidPermit(PermitNotice permitNotice) : base(permitNotice)
		{

		}

		public override void Validate()
		{
			base.Validate();

			_isValid = true;
		}
	}
}