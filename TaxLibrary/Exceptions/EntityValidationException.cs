using System;
using System.Collections.Generic;
using System.Text;
using TaxLibrary.exception;

namespace TaxLibrary.Exceptions
{
    public abstract class EntityValidationException : TaxException
    {
        public EntityValidationException() : base()
        {
        }

        public EntityValidationException(params string[] keys) : base(keys)
        {
        }
    }
}
