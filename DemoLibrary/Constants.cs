namespace DemoLibrary
{
    /// <summary>
    /// Базовые константы
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Точность сравнения.
        /// <remarks>Необходимо как то определить, но сейчас возьмем <see cref="float.Epsilon"/></remarks>
        /// </summary>
        public const double Tolerance = float.Epsilon;
    }
}