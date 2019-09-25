using System;

namespace DemoLibrary
{
    /// <summary>
    /// Класс вычисления базовых характеристик геометрических фигур
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        /// Точность сравнения.
        /// <remarks>Необходимо как то определить, но сейчас возьмем <see cref="float.Epsilon"/></remarks>
        /// </summary>
        public const double Tolerance = float.Epsilon;


        /// <summary>
        /// Вычисление площади любой геометрической фигуры
        /// </summary>
        public static double CalcArea(IFigure figure) => figure.CalcArea();


        /// <summary>
        /// Проверка выполнимости теоремы Пифагора
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool CheckPythagorasTheorem(double a, double b, double c) => Math.Abs(a * a + b * b - c * c) < Tolerance;

    }
}