namespace Chapter._9.Unmodified
{
	public class SchedulingTaskPane: SchedulerPane
	{
		private SchedulingTask _task;

		public SchedulingTaskPane(SchedulingTask task)
		{
			_task = task;
		}

		public void ScheduleTask()
		{
			// here we would like to sense that _task.Run() was called.
		}
	}
}
