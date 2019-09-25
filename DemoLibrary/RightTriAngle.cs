namespace DemoLibrary
{
    /// <summary>
    /// Прямоугольный треугольник. Стороны <see cref="TriAngle.A"/> и <see cref="TriAngle.B"/> - катеты, <see cref="TriAngle.C"/> - гипотенуза
    /// </summary>
    public class RightTriAngle : TriAngle
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">Катет</param>
        /// <param name="b">Катет</param>
        /// <param name="c">Гипотенуза</param>
        internal RightTriAngle(double a, double b, double c) : base(a, b, c)
        {
            
        }

        /// <summary>
        /// Площадь прямоугольного треугольника
        /// </summary>
        /// <returns></returns>
        public override double CalcArea() => A * B / 2;
    }
}