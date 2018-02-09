using NUnit.Framework;
using CSharpCalculator;
using System;

namespace CalcTest
{
	[TestFixture, Category("Pow")]
	class PowTest
	{
		public Calculator calculator;


		[OneTimeSetUp]
		public void SetUp()
		{
			calculator = new Calculator();
		}
		private static object[] positive =
	   {
			new object[] { 0, 0, Math.Pow(0,0)},
			new object[] { 1,3, Math.Pow(1,3)},
			new object[] { -10,-100, Math.Pow(-10,-100) },

			new object[] { -10,100, Math.Pow(-10,100) },
			new object[] { 10,-100, Math.Pow(10,-100) },

			new object[] { 10, 12.5555, Math.Pow(10, 12.5555) },
			new object[] { 0.5, 12, Math.Pow(0.5, 12) },

			new object[] { -0.5, 12, Math.Pow(-0.5, 12) },
			new object[] { -0.005, -1201, Math.Pow(-0.005, -1201) },
			new object[] { 0.005, -1201, Math.Pow(0.005, -1201) },

			new object[] { int.MaxValue, int.MaxValue,  Math.Pow(int.MaxValue, int.MaxValue) },
			new object[] { int.MinValue, int.MinValue, Math.Pow(int.MinValue, int.MinValue) },
			new object[] { int.MinValue, int.MaxValue, Math.Pow(int.MinValue, int.MaxValue) },
			new object[] { double.MaxValue, double.MaxValue,  Math.Pow(double.MaxValue, double.MaxValue) },
			new object[] { double.MinValue, double.MinValue, Math.Pow(double.MinValue, double.MinValue) },
			new object[] { double.MinValue, double.MaxValue,Math.Pow(double.MinValue, double.MaxValue) },
		};

		[TestCaseSource("positive")]
		public void PowTestPositive(double value1, double value2, double expected)
		{
			Assert.AreEqual(calculator.Pow(value1, value2), expected);
		}

		[OneTimeTearDown]
		public void TearDown()
		{
			calculator = null;
		}
	}
}
