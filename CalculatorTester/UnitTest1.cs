using net_calculator_tester;
using System;

namespace CalculatorTester
{
    public class Tests
    {
        [Test]
        [TestCase(2, 3, 5)]
        [TestCase(5, -3, 2)]

        public void Test_Add(float num1, float num2, float result)
        {
            var add = Calculator.Add(num1, num2);
            Assert.That(add, Is.EqualTo(result));
        }

        [Test]
        [TestCase(2, 3, -1)]
        [TestCase(15, 3, 12)]

        public void Test_Subtract(float num1, float num2, float result)
        {
            var sub = Calculator.Subtract(num1, num2);
            Assert.That(sub, Is.EqualTo(result));
        }

        [Test]
        [TestCase(4, 2, 2)]
        [TestCase(15, 3, 5)]

        public void Test_Divide(float num1, float num2, float result)
        {
            var div = Calculator.Divide(num1, num2);
            Assert.That(div, Is.EqualTo(result));
        }

        [Test]
        [TestCase(2, 3, 6)]
        [TestCase(15, 3, 45)]

        public void Test_Multiply(float num1, float num2, float result)
        {
            var mul = Calculator.Multiply(num1, num2);
            Assert.That(mul, Is.EqualTo(result));
        }
    }
}