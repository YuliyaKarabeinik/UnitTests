using NUnit.Framework;
using CSharpCalculator;

namespace CalcTest
{
	[TestFixture, Category("Sub")]
	class SubTest
	{
		public Calculator calculator;


		[OneTimeSetUp]
		public void SetUp()
		{
			calculator = new Calculator();
		}
		private static object[] positive =
	   {
			new object[] { 1,1, 0},
			new object[] { 0,0, 0},
			new object[] { -10,-2, -10-(-2)},
			new object[] { -100,5, -100-5},
			new object[] { 12.5555, 5.425,  12.5555-5.425},
			new object[] { -0.006, 0.002, -0.006-0.002},
			new object[] { int.MaxValue, int.MaxValue, int.MaxValue-int.MaxValue},
			new object[] { int.MinValue, int.MinValue, int.MinValue-int.MinValue},
			new object[] { double.MinValue, double.MaxValue,double.MinValue-double.MaxValue},
		};

		[TestCaseSource("positive")]
		public void SubTestPositive(double value1, double value2, double expected)
		{
			Assert.AreEqual(calculator.Sub(value1, value2), expected);
		}

		[OneTimeTearDown]
		public void TearDown()
		{
			calculator = null;
		}
	}
}
