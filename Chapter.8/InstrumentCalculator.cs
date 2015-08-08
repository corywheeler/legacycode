using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter._8.Exceptions;

namespace Chapter._8
{
	public class InstrumentCalculator
	{
		private List<double> elements;

		public InstrumentCalculator()
		{
			elements = new List<double>();
		}

		public double firstMomentAbout(double point)
		{
			if (elements.Count == 0)
			{
				throw new InvalidBasisException();
			}

			double numerator = 0.0;
			elements.ForEach(element => numerator += element - point);
			return numerator / elements.Count;
		}

		public void addElement(double element)
		{
			elements.Add(element);
		}

		public double secondMomentAbout(double point)
		{
			if (elements.Count == 0)
			{
				throw new InvalidBasisException();
			}

			double numerator = 0.0;
			elements.ForEach(element => numerator += Math.Pow(element - point, 2.0));
			return numerator / elements.Count;
		}
	}

}
