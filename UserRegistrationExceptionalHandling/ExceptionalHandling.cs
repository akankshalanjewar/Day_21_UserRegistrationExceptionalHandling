using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationExceptionalHandling
{
    public class ExceptionHandling : Exception
        {
            public enum ExceptionType
            {
                NULL_FIELD,
                INVALID_INPUT,
            }
            private readonly ExceptionType type;
            public ExceptionHandling(ExceptionType Type, string message) : base(message)
            {
                this.type = Type;
            }
        }
    
}

