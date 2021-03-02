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
    public class CalculatorTests
    {
        SimpleCalculator sc;
        [SetUp]
        public void setUp()
        {
            sc = new SimpleCalculator();
        }
        [Test]
        [TestCase(10, 20, 30)]
        public void AdditionTest(double a, double b, double expected)
        {
            double result = sc.Addition(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TearDown]
        public void tearDown()
        {
            sc = null;
        }

    }
}
