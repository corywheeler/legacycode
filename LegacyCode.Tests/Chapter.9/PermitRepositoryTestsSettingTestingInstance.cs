using Chapter._9;
using NUnit.Framework;

namespace LegacyCode.Tests.Chapter._9
{
	[TestFixture]
	class PermitRepositoryTestsSettingTestingInstance
	{
		private PermitRepository _repository;
		private TestingPermitRepository _testingPermitRepository;
		private Permit _permit1;
		private Permit _permit2;
		private PermitNotice _permitNotice2;
		private PermitNotice _permitNotice1;

		[SetUp]
		public void Init()
		{
			_testingPermitRepository = new TestingPermitRepository();


			_permitNotice1 = new PermitNotice(1, "a");
			_permit1 = new Permit(_permitNotice1);
			_permitNotice2 = new PermitNotice(2, "b");
			_permit2 = new Permit(_permitNotice2);

			_testingPermitRepository.AddAssociatedPermit(_permitNotice1, _permit1 );
			_testingPermitRepository.AddAssociatedPermit(_permitNotice2, _permit2 );

			PermitRepository.SetTestingInstance(_testingPermitRepository);
			_repository = PermitRepository.GetInstance();
		}

		[Test]
		public void IdsShouldBe20WhenReAssigned()
		{
			Assert.AreEqual(20, _testingPermitRepository.Id());
		}

		[Test]
		public void WeShouldFindTheSecondPermit()
		{
			Assert.AreEqual(_permit2.Notice.Owner, _repository.FindAssociatedPermit(_permitNotice2).Notice.Owner);
		}

		[Test]
		public void WeShouldFindTheFirstPermit()
		{
			Assert.AreEqual(_permit1.Notice.Owner, _repository.FindAssociatedPermit(_permitNotice1).Notice.Owner);
		}
	}
}