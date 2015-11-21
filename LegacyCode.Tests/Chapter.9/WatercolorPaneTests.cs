using Chapter._9;
using NUnit.Framework;

namespace LegacyCode.Tests.Chapter._9
{
	[TestFixture]
	class WatercolorPaneTests
	{
		private WatercolorPane _pane;

		[SetUp]
		public void Init()
		{
			Form form = new Form();
			WashBrush border = new WashBrush();
			Pattern backDrop = new Pattern();

			TestingFocusWidget widget = new TestingFocusWidget();
			_pane = new WatercolorPane(form, border, backDrop);

			_pane.SupersedeCursor(widget);
		}

		[Test]
		public void test()
		{
			Assert.AreEqual(0, _pane.GetComponentCount());
		}
	}
}
