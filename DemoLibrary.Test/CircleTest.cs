using System;
using DemoLibrary.Exception;
using NUnit.Framework;

namespace DemoLibrary.Test
{
    [TestFixture]
    internal class CircleTest
    {
        [TestCase(-1)]
        [TestCase(-2.5)]
        [TestCase(-3.7)]
        [TestCase(-42)]
        public void Circle_Constructor_ThrowsNegativeLengthException(double radius)
        {
            Assert.Throws<NegativeLengthException>(() => new Circle(radius));
        }

        [TestCase(0)]
        public void Circle_Constructor_ThrowsZeroLengthException(double radius)
        {
            Assert.Throws<ZeroLengthException>(() => new Circle(radius));
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(2.5)]
        [TestCase(42)]
        [TestCase(0.001)]
        public void Circle_Constructor_CalcArea(double radius)
        {
            Assert.AreEqual(new Circle(radius).CalcArea(), Math.PI * radius * radius);
        }
    }
}
