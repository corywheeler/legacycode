using Chapter._9;
using NUnit.Framework;

namespace LegacyCode.Tests.Chapter._9
{
	[TestFixture]
	class PermitRepositoryTestsSettingTestingInstance
	{
		private PermitRepository _repository;
		private TestingPermitRepository _testingPermitRepository;

		[SetUp]
		public void Init()
		{
			_testingPermitRepository = new TestingPermitRepository();
			PermitRepository.SetTestingInstance(_testingPermitRepository);
			_repository = PermitRepository.GetInstance();
		}

		[Test]
		public void IdsShouldBe20WhenReAssigned()
		{
			Assert.AreEqual(20, _testingPermitRepository.Id());
		}
	}
}