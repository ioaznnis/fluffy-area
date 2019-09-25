using System;
using System.Runtime.Serialization;

namespace DemoLibrary.Exception
{
    /// <summary>
    /// Представляет ошибку, возникающую когда длинна фигуры равна 0
    /// </summary>
    [Serializable]
    public class ZeroLengthException : LengthException
    {
        public ZeroLengthException():this("Нулевая длинна геометрической фигуры.")
        {
        }

        public ZeroLengthException(string message) : base(message)
        {
        }

        public ZeroLengthException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected ZeroLengthException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}