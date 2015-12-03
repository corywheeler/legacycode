using Chapter._9;
using NUnit.Framework;

namespace LegacyCode.Tests.Chapter._9
{
	[TestFixture]
	class FacilityTests
	{
		private Facility _facility;

		[SetUp]
		public void Init()
		{
			PermitNotice notice = new PermitNotice(0, "a");
			_facility = new Facility(Facility.Residence, "b", notice);
		}

		[Test]
		public void TestCreate()
		{
			Assert.IsInstanceOf<Facility>(_facility);
		}
	}
}
