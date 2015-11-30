using Chapter._9;

namespace LegacyCode.Tests.Chapter._9
{
	public class MockFocusWidget : IFocusWidget
	{
		public int TimesGetComponentCountWasCalled { get; private set; }

		public MockFocusWidget()
		{
			TimesGetComponentCountWasCalled = 0;
		}

		public int GetComponentCount()
		{
			TimesGetComponentCountWasCalled += 1;
			return 0;
		}
	}
}