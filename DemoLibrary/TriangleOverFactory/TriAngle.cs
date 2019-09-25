using System;
using DemoLibrary.Exception;

namespace DemoLibrary.TriangleOverFactory
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class TriAngle : IFigure
    {
        /// <summary>
        /// Длинна стороны a
        /// </summary>
        public double A { get; }

        /// <summary>
        /// Длинна стороны b
        /// </summary>

        public double B { get; }

        /// <summary>
        /// Длинна стороны c
        /// </summary>
        public double C { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"><see cref="A"/></param>
        /// <param name="b"><see cref="B"/></param>
        /// <param name="c"><see cref="C"/></param>
        internal TriAngle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new NegativeLengthException();
            }

            if (Math.Abs(a) < Constants.Tolerance ||
                Math.Abs(b) < Constants.Tolerance ||
                Math.Abs(c) < Constants.Tolerance)
            {
                throw new ZeroLengthException();
            }

            A = a;
            B = b;
            C = c;
        }


        /// <summary>
        /// Площадь треугольника
        /// </summary>
        /// <returns></returns>
        public virtual double CalcArea()
        {
            var s = (A + B + C) / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }
    }
}