using System.Runtime.InteropServices.ComTypes;

namespace Chapter._9.Unmodified
{
	public class WatercolorPane
	{
		private Panel _anteriorPanel;
		private Panel _backgroundPanel;
		private FocusWidget _cursor;

		public WatercolorPane(Form border, WashBrush brush, Pattern backdrop)
		{
			_anteriorPanel = new Panel(border);
			_anteriorPanel.SetBorderColor(brush.GetForeColor());
			_backgroundPanel = new Panel(border, backdrop);

			_cursor = new FocusWidget(brush, _backgroundPanel);
		} 
	}
}