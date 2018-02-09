using NUnit.Framework;
using CSharpCalculator;

namespace CalcTest
{
    [TestFixture, Category("Add")]
    public class AddTest
    {

        public Calculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new Calculator();
        }
        private static object[] positive =
        {
            new object[] { 1,1,2},
            new object[] { -10,20,10},
            new object[] { 0,0,0},
            new object[] { -5,-15,-20},
            new object[] { 1.0001, 2.0001, 3.0002},
           new object[] { 1.0001, -2.0001, -1},
           new object[] { -1.0001,-2.0001, -3.0002},
            new object[] { int.MinValue, int.MaxValue,0},
            new object[] { double.MinValue, double.MaxValue,0},
        };

        [TestCaseSource("positive")]
        public void AddTestPositive(double value1,double value2, double expected)
        {
            Assert.AreEqual(calculator.Add(value1,value2), expected);
        }


        [OneTimeTearDown]
        public void TearDown()
        {
            calculator = null;
        }

    }

}
