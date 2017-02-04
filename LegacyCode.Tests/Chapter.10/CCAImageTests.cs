using System;
using NUnit.Framework;

namespace LegacyCode.Tests.Chapter._10
{
	[TestFixture]
	class CCAImageTests
	{
		private TestingCCAImage _ccaImage;

		[SetUp]
		public void Init()
		{
			_ccaImage = new TestingCCAImage();
		}

		[Test] [ExpectedException(typeof(NotImplementedException))]
		public void TestWeCanCallSetSnapRegion()
		{
			_ccaImage.SetSnapRegion(1,2,3,4);
		}
	}
}
