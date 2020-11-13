using System;
using System.Collections.Generic;
using System.Text;

namespace Unity_Csharp___Completo.ExercicioException.Entities
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
