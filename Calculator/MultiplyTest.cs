using NUnit.Framework;
using CSharpCalculator;

namespace CalcTest
{
	[TestFixture, Category("Multiply")]
	class MultiplyTest
	{
		public Calculator calculator;

		[OneTimeSetUp]
		public void SetUp()
		{
			calculator = new Calculator();
		}
		private static object[] positive =
	   {
			new object[] { 10,5, 10*5},
			new object[] { -10,-2, -10*-2},
			new object[] { -100,5, -100*5},
			new object[] { 12.5, 5, 12.5*5},
		   new object[] { -0.6, 0.2, -0.6*0.2},
		   new object[] { 0, 0, 0},
			new object[] { double.MaxValue, double.MaxValue,double.MaxValue*double.MaxValue},
			new object[] { double.MinValue, double.MaxValue,double.MinValue*double.MaxValue},
			new object[] { double.MinValue, double.MinValue,double.MinValue*double.MinValue},
		};

		[TestCaseSource("positive")]
		public void MultiplyTestPositive(double value1, double value2, double expected)
		{
			Assert.AreEqual(calculator.Multiply(value1, value2), expected);
		}



		[OneTimeTearDown]
		public void TearDown()
		{
			calculator = null;
		}
	}
}
