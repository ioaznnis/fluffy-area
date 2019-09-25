using System;
using System.Linq;
using DemoLibrary.Exception;

namespace DemoLibrary
{
    /// <summary>
    /// Альтернативный вариант класса "треугольник", так как нам надо знать только площадь
    /// </summary>
    public class Triangle : IFigure
    {
        /// <summary>
        /// Массив сторон, упорядоченный по убыванию, т.е. первый элемент - возможно гипотенуза
        /// </summary>
        private readonly double[] _parts;

        public Triangle(double a, double b, double c)
        {
            var parts = new[] {a, b, c}.OrderByDescending(d => d).ToArray();

            if (parts.Any(x => x < 0))
            {
                throw new NegativeLengthException();
            }

            if (parts.Any(x => Math.Abs(x) < Constants.Tolerance))
            {
                throw new ZeroLengthException();
            }

            _parts = parts;
        }

        /// <summary>
        /// Подсчет суммы квадратов катетов минус квадрат гипотенузы
        /// </summary>
        /// <returns></returns>
        private double PythagorasTheorem()
        {
            var accumulate = 0d;

            var first = true;
            foreach (var part in _parts)
            {
                if (first)
                {
                    accumulate -= part * part;
                    first = false;
                }
                else
                {
                    accumulate += part * part;
                }
            }

            return accumulate;
        }

        public double CalcArea()
        {
            if (Math.Abs(PythagorasTheorem()) < Constants.Tolerance)
            {
                //Если теорема пифагора выполняется, то _parts[0] - гипотенуза, а остальные - катеты
                return _parts[1] * _parts[2] / 2;
            }

            var semiPerimeter = _parts.Sum() / 2;
            return Math.Sqrt(semiPerimeter * _parts.Select(x => semiPerimeter - x).Aggregate((x, y) => x * y));
        }
    }
}