using Chapter._9;
using Moq;
using NUnit.Framework;

namespace LegacyCode.Tests.Chapter._9
{
	[TestFixture]
	class SchedulingTaskPaneTests
	{
		private SchedulingTask _schedulingTask;

		[SetUp]
		public void Init()
		{
			var meetingResolver = new MeetingResolver();
			var scheduler = new Scheduler();
			_schedulingTask = new SchedulingTask(scheduler, meetingResolver);
			var schedulingTaskPane = new SchedulingTaskPane(_schedulingTask);
			schedulingTaskPane.ScheduleTask();
		}

		[Test]
		public void SchedulingTaskShouldBeCalledOnce()
		{
			_schedulingTask.Verify(task => task.Run(), Times.Once);
		}
	}
}
