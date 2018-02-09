using NUnit.Framework;
using CSharpCalculator;
using System;

namespace CalcTest
{


	[TestFixture, Category("Sqrt")]
	class SqrtTest
	{
		public Calculator calculator;


		[OneTimeSetUp]
		public void SetUp()
		{
			calculator = new Calculator();
		}
		private static object[] positive =
	   {
			new object[] { 0, Math.Sqrt(0)},
			new object[] { 1, Math.Sqrt(1)},
			new object[] { -10, Math.Sqrt(-10) },
			new object[] {  12.5555, Math.Sqrt(12.5555) },
			new object[] { 0.5, Math.Sqrt(0.5) },
			new object[] { int.MaxValue, Math.Sqrt(int.MaxValue) },
			new object[] { int.MinValue,Math.Sqrt(int.MinValue) },
			new object[] { double.MaxValue, Math.Sqrt(double.MaxValue) },
			new object[] { double.MinValue,Math.Sqrt(double.MinValue) },

	};

		[TestCaseSource("positive")]
		public void SqrtTestPositive(double value, double expected)
		{
			Assert.AreEqual(calculator.Sqrt(value), expected);
		}

		[OneTimeTearDown]
		public void TearDown()
		{
			calculator = null;
		}
	}
}
