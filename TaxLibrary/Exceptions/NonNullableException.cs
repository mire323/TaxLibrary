using System;
using System.Collections.Generic;
using System.Text;

namespace TaxLibrary.Exceptions
{
    public class NonNullableException : EntityValidationException
    {
        public NonNullableException(string name) : base(name)
        {

        }

        public NonNullableException(Type type, string columnName) : this(type.Name + "." + columnName + ".title")
        {
        }
    }
}
