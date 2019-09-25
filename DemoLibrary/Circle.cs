using System;
using DemoLibrary.Exception;

namespace DemoLibrary
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : IFigure
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new NegativeLengthException();
            }

            if (Math.Abs(radius) < Calculator.Tolerance)
            {
                throw new ZeroLengthException();
            }

            Radius = radius;
        }

        /// <summary>
        /// Площадь круга
        /// </summary>
        /// <returns></returns>
        public double CalcArea() => Math.PI * Radius * Radius;
    }
}