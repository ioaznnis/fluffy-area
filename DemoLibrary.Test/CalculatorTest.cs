using NUnit.Framework;

namespace DemoLibrary.Test
{
    [TestFixture]
    internal class CalculatorTest
    {
        [TestCase(1, 1, 1)]
        [TestCase(2, 3, 4)]
        [TestCase(1, 3, 5)]
        [TestCase(-1, -2, 5)]
        public void CheckPythagorasTheorem_ReturnFalse(double a, double b, double c)
        {
            Assert.False(Calculator.CheckPythagorasTheorem(a, b, c));
        }


        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 5)]
        [TestCase(-3, -4, -5)]
        public void CheckPythagorasTheorem_ReturnTrue(double a, double b, double c)
        {
            Assert.True(Calculator.CheckPythagorasTheorem(a, b, c));
        }
    }
}