using NUnit.Framework;
using Chapter._9;

namespace LegacyCode.Tests.Chapter._9
{
	[TestFixture]
	public class IndustrialFacilityTests
	{
		
		private Facility _facility;

		[SetUp]
		public void Init()
		{
			_facility = new IndustrialFacility(Facility.HT_1, "b", new AlwaysValidPermit());
		}

		[Test]
		public void FacilityShouldHavePermits()
		{
			Assert.True(_facility.HasPermits());
		}
	}
}