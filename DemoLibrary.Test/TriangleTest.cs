using System;
using NUnit.Framework;

namespace DemoLibrary.Test
{
	[TestFixture]
    public class TriangleTest
    {
        [TestCase(9, 9, 9, 35.074d)]
        [TestCase(2, 3, 4, 2.9047d)]
        [TestCase(3, 4, 5, 6)]
        public void TriAngleFactory_CalcArea(double a, double b, double c, double area)
        {
            Assert.LessOrEqual(Math.Abs(new Triangle(a, b, c).CalcArea() - area), 0.0001d);
        }
    }
}
