﻿using System;
using DemoLibrary.Exception;
using DemoLibrary.TriangleOverFactory;
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
        [TestCase(1d / 9E84d, 1, 12)]
        public void TriAngleFactory_Constructor_ThrowsZeroLengthException(double a, double b, double c)
        {
            Assert.Throws<ZeroLengthException>(() => TriAngleFactory.Create(a, b, c));
        }

        [TestCase(1, 1, 1)]
        [TestCase(2, 3, 4)]
        [TestCase(1, 3, 5)]
        [TestCase(-1, -2, 5)]
        public void CheckPythagorasTheorem_ReturnFalse(double a, double b, double c)
        {
            Assert.False(TriAngleFactory.CheckPythagorasTheorem(a, b, c));
        }


        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 5)]
        [TestCase(-3, -4, -5)]
        public void CheckPythagorasTheorem_ReturnTrue(double a, double b, double c)
        {
            Assert.True(TriAngleFactory.CheckPythagorasTheorem(a, b, c));
        }


        [TestCase(9, 9, 9, 35.074d)]
        [TestCase(2, 3, 4, 2.9047d)]
        [TestCase(3, 4, 5, 6)]
        public void TriAngleFactory_CalcArea(double a, double b, double c, double area)
        {
            Assert.LessOrEqual(Math.Abs(TriAngleFactory.Create(a, b, c).CalcArea() - area), 0.0001d);
        }
    }
}