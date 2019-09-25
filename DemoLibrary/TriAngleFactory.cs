namespace DemoLibrary
{
    /// <summary>
    /// Фабрика, определяющая тип треугольника, и создающая его.
    /// </summary>
    public static class TriAngleFactory
    {
        public static TriAngle Create(double a, double b, double c)
        {
            if (Calculator.CheckPythagorasTheorem(a, b, c)) return new RightTriAngle(a, b, c);
            if (Calculator.CheckPythagorasTheorem(a, c, b)) return new RightTriAngle(a, c, b);
            if (Calculator.CheckPythagorasTheorem(b, c, a)) return new RightTriAngle(b, c, a);

            return new TriAngle(a, b, c);
        }
    }
}