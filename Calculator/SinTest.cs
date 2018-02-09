using CSharpCalculator;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTest
{
	[TestFixture, Category("Sin")]
	class SinTest
	{

		public Calculator calc;

		[OneTimeSetUp]
		public void SetUp()
		{
			calc = new Calculator();
		}
		private static object[] positive =
		{
			new object[] { 50, Math.Sin(50)},
			new object[] { -10, Math.Sin(-10)},
			new object[] { 0, Math.Sin(0)},
			new object[] { -101.1235, Math.Sin(-101.1235) },
			new object[] { 0.1235, Math.Sin(0.1235) },
			new object[] { int.MinValue, Math.Sin(int.MinValue) },
			new object[] { int.MaxValue, Math.Sin(int.MaxValue) },
			new object[] { double.MinValue, Math.Sin(double.MinValue)},
			new object[] { double.MaxValue, Math.Sin(double.MaxValue)},
		};

		[TestCaseSource("positive")]
		public void SinTestPositive(double value, double expected)
		{
			Assert.AreEqual(calc.Sin(value), expected);
		}

		[OneTimeTearDown]
		public void TearDown()
		{
			calc = null;
		}


	}
}
