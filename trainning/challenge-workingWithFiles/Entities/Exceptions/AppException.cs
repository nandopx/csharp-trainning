using System;

namespace workingWithFiles
{
    class AppException : ApplicationException
    {
        public AppException (string message) : base(message)
        {
        }
    }
}
