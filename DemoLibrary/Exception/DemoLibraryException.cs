using System;
using System.Runtime.Serialization;

namespace DemoLibrary.Exception
{
    /// <summary>
    /// Базовый класс исключений библиотеки
    /// </summary>
    [Serializable]
    public abstract class DemoLibraryException : System.Exception
    {
        protected DemoLibraryException()
        {
        }

        protected DemoLibraryException(string message) : base(message)
        {
        }

        protected DemoLibraryException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected DemoLibraryException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}