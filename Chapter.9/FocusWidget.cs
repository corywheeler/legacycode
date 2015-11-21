namespace Chapter._9
{
	public interface IFocusWidget
	{
		int GetComponentCount();
	}

	public class FocusWidget : IFocusWidget
	{
		public FocusWidget()
		{
			
		}

		public FocusWidget(WashBrush brush, Panel backgroundPanel)
		{
			
		}

		public virtual int GetComponentCount()
		{
			return 0;
		}
	}
}