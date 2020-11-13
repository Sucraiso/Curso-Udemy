using System;
using System.Collections.Generic;
using System.Text;

namespace Unity_Csharp___Completo.ExemploException.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
