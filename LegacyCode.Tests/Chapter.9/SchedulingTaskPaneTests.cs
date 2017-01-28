using Chapter._9;
using Moq;
using NUnit.Framework;

namespace LegacyCode.Tests.Chapter._9
{
	[TestFixture]
	class SchedulingTaskPaneTests
	{
		private Mock<ISchedulingTask> _schedulingTask;

		[SetUp]
		public void Init()
		{
			_schedulingTask = new Mock<ISchedulingTask>();
			var schedulingTaskPane = new SchedulingTaskPane(_schedulingTask.Object);
			schedulingTaskPane.ScheduleTask();
		}

		[Test]
		public void SchedulingTaskShouldBeCalledOnce()
		{
			_schedulingTask.Verify(task => task.Run(), Times.Once);
		}
	}
}