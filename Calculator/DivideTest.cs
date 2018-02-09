using NUnit.Framework;
using CSharpCalculator;

namespace CalcTest
{
	[TestFixture, Category("Divide")]
	class DivideTest
	{
		public Calculator calculator;


		[OneTimeSetUp]
		public void SetUp()
		{
			calculator = new Calculator();
		}
		private static object[] positive =
	   {
			new object[] { 1,1, 1/1},
			new object[] { -10,-2, -10/-2},
			new object[] { -100,5, -100/5},
			new object[] { 12.5, 5, 12.5/5},
		    new object[] { -0.6, 0.2, -0.6/0.2},
			new object[] { int.MinValue, int.MaxValue, int.MinValue/int.MaxValue},
			new object[] { double.MinValue, double.MaxValue,-1},
		};

		[TestCaseSource("positive")]
		public void DivideTestPositive(double value1, double value2, double expected)
		{
			Assert.AreEqual(calculator.Divide(value1, value2), expected);
		}

		[OneTimeTearDown]
		public void TearDown()
		{
			calculator = null;
		}
	}
}
