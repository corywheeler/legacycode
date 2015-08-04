using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			double numerator = 0.0;
			elements.ForEach(element => numerator += element - point);
			return numerator / elements.Count;
		}

		public void addElement(double element)
		{
			elements.Add(element);
		}
	}

}
