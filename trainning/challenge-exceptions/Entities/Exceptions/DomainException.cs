using System;

namespace challenge_exceptions.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException ( string message ) : base( message ) { }
    }
}
