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
			return nthMomentAbout(point, 1.0);
		}

		public void addElement(double element)
		{
			elements.Add(element);
		}

		public double secondMomentAbout(double point)
		{
			return nthMomentAbout(point, 2.0);
		}

		private double nthMomentAbout(double point, double n)
		{
			if (elements.Count == 0)
			{
				throw new InvalidBasisException();
			}

			double numerator = 0.0;
			elements.ForEach(element => numerator += Math.Pow(element - point, n));
			return numerator/elements.Count;
		}
	}

}
