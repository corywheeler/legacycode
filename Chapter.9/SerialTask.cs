using System;

namespace Chapter._9
{
	public class SerialTask
	{
		public SerialTask()
		{
			
		}

		public void Run()
		{
			Console.WriteLine("Run from SerialTask invoked.");
		}

		protected virtual void OverRidableMethod1()
		{
			Console.WriteLine("Called OverRidableMethod1 from SerialTask.");
		}

		protected virtual void OverRidableMethod2()
		{
			Console.WriteLine("Called OverRidableMethod2 from SerialTask.");
		}

	}
}