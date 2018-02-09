using NUnit.Framework;
using CSharpCalculator;

namespace CalcTest
{
	[TestFixture, Category("Abs")]
	public class AbsTest
	{

		public Calculator calculator;


        [OneTimeSetUp]
        public void SetUp()
        {
            calculator = new Calculator();
        }
        private static object[] positive =
		{
			new object[] { 1,1},
			new object[] { -10,10},
			new object[] { 0,0},
			new object[] { -10.1235, 10.1235},
			new object[] { -0.1235, 0.1235},
			new object[] { int.MinValue, int.MaxValue},
			new object[] { double.MinValue, double.MaxValue},
		};

		[TestCaseSource("positive")]
		public void AbsTestPositive(double value, double expected)
		{
			Assert.AreEqual(calculator.Abs(value), expected);
		}

		
	private static object[] negative =
		{
			new object[] { 1,-1},
			new object[] { -10,-10},
			new object[] { 1.1235, -1.1235},
			new object[] { int.MaxValue, int.MinValue},
			new object[] { double.MaxValue, double.MinValue},
		
		};
		[TestCaseSource("negative")]
		public void AbsTestNegative(double value, double expected)
		{
			Assert.AreNotEqual(calculator.Abs(value), expected);
		}

		[OneTimeTearDown]
		public void TearDown()
		{
            calculator =null;
        }

	}
}
