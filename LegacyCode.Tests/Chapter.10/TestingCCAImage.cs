using Chapter._10;

namespace LegacyCode.Tests.Chapter._10
{
	public class TestingCCAImage : CCAImage
	{
		public new void SetSnapRegion(int x, int y, int dx, int dy)
		{
			base.SetSnapRegion(x, y, dx, dy);
		}
	}
}
