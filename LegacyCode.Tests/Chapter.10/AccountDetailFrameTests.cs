using NUnit.Framework;

namespace LegacyCode.Tests.Chapter._10
{
    [TestFixture]
    public class AccountDetailFrameTests
    {
        private TestingAccountDetailFrame _frame;

        [SetUp]
		public void Init()
		{
            _frame = new TestingAccountDetailFrame();
		}

        [Test]
        public void TestPerformCommand() {
            _frame.SetAccountSymbol("SYM");
            _frame.PerformCommand("project activity");
            Assert.AreEqual("SYM: basic account", _frame.GetDisplayText());
        }
    }
}
