using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter._8.Exceptions
{
	public class InvalidBasisException : Exception
	{
		public InvalidBasisException()
		{
			
		}

		public InvalidBasisException(string message) : base(message)
		{
			
		}

		public InvalidBasisException(string message, Exception inner) : base(message, inner)
		{
			
		}
	}
}
