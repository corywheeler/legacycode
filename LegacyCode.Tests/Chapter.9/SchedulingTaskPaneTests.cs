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
			var meetingResolver = new MeetingResolver();
			var scheduler = new Scheduler();
			var schedulingTask = new SchedulingTask(scheduler, meetingResolver);
			var schedulingTaskPane = new SchedulingTaskPane(schedulingTask);
		}
	}
}
