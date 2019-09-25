using System;
using System.Linq;

namespace DemoLibrary.TriangleOverFactory
{
    /// <summary>
    /// Фабрика, определяющая тип треугольника, и создающая его.
    /// </summary>
    public static class TriAngleFactory
    {
        public static TriAngle Create(double a, double b, double c)
        {
            //Отсортируем стороны, что бы найти гипотенузу, как самую большую
            var doubles = new[] {a, b, c}.OrderBy(d => d).ToArray();
            if (CheckPythagorasTheorem(doubles[0], doubles[1], doubles[2])) return new RightTriAngle(a, b, c);

            return new TriAngle(a, b, c);
        }

        /// <summary>
        /// Проверка выполнимости теоремы Пифагора
        /// </summary>
        /// <param name="a">Катет</param>
        /// <param name="b">Катет</param>
        /// <param name="c">Гипотенуза</param>
        /// <returns></returns>
        public static bool CheckPythagorasTheorem(double a, double b, double c) =>
            Math.Abs(a * a + b * b - c * c) < Constants.Tolerance;
    }
}