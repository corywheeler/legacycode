using Chapter._9;
using Moq;
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
			var form = new Form();
			var border = new WashBrush();
			var backDrop = new Pattern();

			var widget = new TestingFocusWidget();
			_pane = new WatercolorPane(form, border, backDrop);

			_pane.SupersedeCursor(widget);
		}

		[Test]
		public void TestComponentCount()
		{
			Assert.AreEqual(0, _pane.GetComponentCount());
		}

		[Test]
		public void TestWidgetIsCalledUsingMockOfConcreteObject()
		{
			var focusWidget = new Mock<FocusWidget>();
			_pane.SupersedeCursor(focusWidget.Object);
			_pane.GetComponentCount();

			focusWidget.Verify(widget => widget.GetComponentCount(), Times.Once);

		}

		[Test]
		public void TestWidgetIsCalledUsingMockOfInterface()
		{
			var focusWidget = new Mock<IFocusWidget>();
			_pane.SupersedeCursor(focusWidget.Object);
			_pane.GetComponentCount();

			focusWidget.Verify(widget => widget.GetComponentCount(), Times.Once);
		}

		[Test]
		public void TestWidgetIsCalledUsingHandRolledMockObject()
		{
			var focusWidget = new MockFocusWidget();
			_pane.SupersedeCursor(focusWidget);
			_pane.GetComponentCount();

			Assert.AreEqual(1, focusWidget.TimesGetComponentCountWasCalled);
		}

	}
}
