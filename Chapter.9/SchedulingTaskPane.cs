namespace Chapter._9
{
	public class SchedulingTaskPane: SchedulerPane
	{
		private ISchedulingTask _task;

		public SchedulingTaskPane(ISchedulingTask task)
		{
			_task = task;
		}

		public void ScheduleTask()
		{
			// here we would like to sense that _task.Run() was called.
			_task.Run();
		}
	}
}
