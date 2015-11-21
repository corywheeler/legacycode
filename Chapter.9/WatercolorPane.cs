namespace Chapter._9
{
	public class WatercolorPane
	{
		private Panel _anteriorPanel;
		private Panel _backgroundPanel;
		private FocusWidget _cursor;
		private int _componentCount;

		public WatercolorPane(Form border, WashBrush brush, Pattern backdrop)
		{
			_componentCount = 0;

			_anteriorPanel = new Panel(border);
			_anteriorPanel.SetBorderColor(brush.GetForeColor());
			_backgroundPanel = new Panel(border, backdrop);

			_cursor = new FocusWidget(brush, _backgroundPanel);
		}

		public int GetComponentCount()
		{
			var widgetComponentCount = _cursor.GetComponentCount();
			return _componentCount + widgetComponentCount;
		}

		public void SupersedeCursor(FocusWidget widget)
		{
			_cursor = widget;
		}
	}
}