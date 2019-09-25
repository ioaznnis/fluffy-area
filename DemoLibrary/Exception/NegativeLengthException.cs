using System;
using System.Runtime.Serialization;

namespace DemoLibrary.Exception
{
    /// <summary>
    /// Представляет ошибку, возникающую когда длинна фигуры отрицательная
    /// </summary>
    [Serializable]
    public class NegativeLengthException : LengthException
    {
        public NegativeLengthException() : this("Отрицательная длинна геометрической фигуры.")
        {
        }

        protected NegativeLengthException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public NegativeLengthException(string message) : base(message)
        {
        }

        public NegativeLengthException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}