﻿using System;
using Chapter._8;
using Chapter._8.Exceptions;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace LegacyCode.Tests.Chapter._8
{
	[TestFixture]
	public class InstrumentCalculatorTests
	{
		[SetUp]
		public void Init()
		{
			
		}

		[Test]
		public void testFirstMoment()
		{
			InstrumentCalculator calculator = new InstrumentCalculator();
			calculator.addElement(1.0);
			calculator.addElement(2.0);

			double TOLERANCE = 0;
			Assert.AreEqual(-0.5, calculator.firstMomentAbout(2.0), TOLERANCE);
		}

		[Test] [ExpectedException(typeof(InvalidBasisException))]
		public void testFirstMomentThrowsInvalidBasisException()
		{
				new InstrumentCalculator().firstMomentAbout(0.0);

		}

	}
}