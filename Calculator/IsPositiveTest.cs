using NUnit.Framework;
using CSharpCalculator;

namespace CalcTest
{
	[TestFixture, Category("IsPositive")]
	class IsPositiveTest
	{
		public Calculator calculator;


		[OneTimeSetUp]
		public void SetUp()
		{
			calculator = new Calculator();
		}

		private static object[] positive =
	   {

			new object[] {10, false},
			new object[] { -10, true},
			new object[] {10.15 ,false },
			new object[] {-0.111, true},
			new object[] {int.MinValue, true},
			new object[] {int.MaxValue, false},
			new object[] {double.MinValue, true },
			new object[] {double.MaxValue, false },};

		[TestCaseSource("positive")]
		public void IsPositiveTestPositive(double value, bool expected)
		{
			Assert.AreNotEqual(calculator.isPositive(value), expected);
		}

		private static object[] negative =
	   {

			new object[] {0, false},
			new object[] {0, true},
		};

		[TestCaseSource("negative")]
		public void IsNegativeTestPositive(double value, bool expected)
		{
			Assert.AreNotEqual(calculator.isPositive(value), expected);
		}


		[OneTimeTearDown]
		public void TearDown()
		{
			calculator = null;
		}
	}
}
