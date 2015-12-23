namespace Chapter._9
{
	public class SchedulingTaskPane: SchedulerPane
	{
		private SchedulingTask _task;

		public SchedulingTaskPane(SchedulingTask task)
		{
			_task = task;
		}

		public void CallRunOnTask()
		{
			// here we would like to sense that _task.Run() was called.
		}
	}
}
