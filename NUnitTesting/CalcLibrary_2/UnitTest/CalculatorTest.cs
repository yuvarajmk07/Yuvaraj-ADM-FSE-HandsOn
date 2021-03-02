using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcLibrary;
using NUnit.Framework;
namespace UnitTest
{
    [TestFixture]
    public class CalculatorTest
    {
        SimpleCalculator sc;
        [SetUp]
        public void setUp()
        {
            sc = new SimpleCalculator();
        }
        
        [TestCase(20, 10, 10)]
        [TestCase(40, 20, 20)]
        public void SubtractionTest(double a, double b, double expected)
        {
            double result = sc.Subtraction(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase(10, 10, 100)]
        [TestCase(20, 10, 200)]

        public void MultiplicationTest(double a, double b, double expected)
        {
            double result = sc.Multiplication(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase(9, 3, 3)]
        [TestCase(25, 5, 5)]
        [TestCase(15,0,0)]
        public void DivisionTest(double a, double b, double expected)
        {
            try
            {
                double result = sc.Division(a, b);
                Assert.AreEqual(expected, result);
               
            }
            catch
            {
                Assert.Fail("Division by Zero");
            }
        }

        [TestCase(10, 10, 20)]
        [TestCase(25, 25, 50)]
        public void TestAddAndClear(double a, double b, double expected)
        {
            double result = sc.Addition(a, b);
            Assert.AreEqual(expected, result);
            sc.AllClear();
            Assert.AreEqual(0, sc.GetResult);


        }
        [TearDown]
        public void tearDown()
        {
            sc = null;
        }
    }

}
