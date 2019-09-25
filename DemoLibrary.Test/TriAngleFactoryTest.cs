using DemoLibrary.Exception;
using NUnit.Framework;

namespace DemoLibrary.Test
{
    [TestFixture]
    internal class TriAngleFactoryTest
    {
        [TestCase(1, 1, 1)]
        [TestCase(2, 3, 4)]
        [TestCase(1, 3, 5)]
        [TestCase(3, 4, 5)]
        public void TriAngleFactory_Create_ReturnsTriAngle(double a, double b, double c)
        {
            Assert.IsInstanceOf<TriAngle>(TriAngleFactory.Create(a, b, c));
        }

        [TestCase(3, 4, 5)]
        public void TriAngleFactory_Create_RightTriAngle(double a, double b, double c)
        {
            Assert.IsInstanceOf<RightTriAngle>(TriAngleFactory.Create(a, b, c));
        }

        [TestCase(1, -1, 1)]
        [TestCase(2, 3, -4)]
        [TestCase(-1, 3, 5)]
        [TestCase(-3, -4, -5)]
        [TestCase(-3, 4, -5)]
        public void TriAngleFactory_Constructor_ThrowsNegativeLengthException(double a, double b, double c)
        {
            Assert.Throws<NegativeLengthException>(() => TriAngleFactory.Create(a, b, c));
        }

        [TestCase(0, 0, 0)]
        [TestCase(0, 3, 4)]
        [TestCase(1, 0, 5)]
        [TestCase(0, 9, 5)]
        [TestCase(1d/9E84d, 1, 12)]
        public void TriAngleFactory_Constructor_ThrowsZeroLengthException(double a, double b, double c)
        {
            Assert.Throws<ZeroLengthException>(() => TriAngleFactory.Create(a, b, c));
        }
    }
}
