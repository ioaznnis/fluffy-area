using System;
using System.Runtime.Serialization;

namespace DemoLibrary.Exception
{
    /// <summary>
    /// Класс ошибок, возникающих при ошибках с длинной
    /// </summary>
    [Serializable]
    public class LengthException : DemoLibraryException
    {
        public LengthException()
        {
        }

        public LengthException(string message) : base(message)
        {
        }

        public LengthException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected LengthException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}