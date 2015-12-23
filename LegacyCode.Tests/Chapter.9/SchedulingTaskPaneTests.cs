using Chapter._9;
using NUnit.Framework;

namespace LegacyCode.Tests.Chapter._9
{
	[TestFixture]
	class SchedulingTaskPaneTests
	{
		[SetUp]
		public void Init()
		{
			var schedulingTaskPane = new SchedulingTaskPane(new SchedulingTask(new Scheduler(), new MeetingResolver()));
		}
	}
}
