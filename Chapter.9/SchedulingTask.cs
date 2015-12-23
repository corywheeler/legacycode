using System;

namespace Chapter._9
{
	public class SchedulingTask: SerialTask, ISchedulingTask
	{
		public SchedulingTask(Scheduler scheduler, MeetingResolver resolver)
		{
			
		}

		protected override void OverRidableMethod1()
		{
			Console.WriteLine("Called OverRidableMethod1 from SchedulingTask");
		}

		protected override void OverRidableMethod2()
		{
			Console.WriteLine("Called OverRidableMethod2 from SchedulingTask");
		}
	}
}