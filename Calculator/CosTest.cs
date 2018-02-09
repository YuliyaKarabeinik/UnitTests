using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CSharpCalculator;

namespace CalcTest
{
    [TestFixture, Category("Cos")]
    class CosTest
    {
        
        public Calculator calc;

        [OneTimeSetUp]
        public void SetUp()
        {
            calc = new Calculator();
        }
        private static object[] positive =
        {
            new object[] { 50, Math.Cos(50)},
            new object[] { -10, Math.Cos(-10)},
            new object[] { 0, Math.Cos(0)},
            new object[] { -101.1235, Math.Cos(-101.1235) },
			new object[] { 0.1235, Math.Cos(0.1235) },
			new object[] { int.MinValue, Math.Cos(int.MinValue) },
			new object[] { int.MaxValue, Math.Cos(int.MaxValue) },
			new object[] { double.MinValue, Math.Cos(double.MinValue)},
			new object[] { double.MaxValue, Math.Cos(double.MaxValue)},
		};

        [TestCaseSource("positive")]
        public void CosTestPositive(double value, double expected)
        {
            Assert.AreEqual(calc.Cos(value), expected);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            calc = null;
        }


    }
}
