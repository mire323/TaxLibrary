using System;
using System.Collections.Generic;
using System.Text;
using TaxLibrary.exception;

namespace TaxLibrary.Exceptions
{
    public class NonPermittedNullParameterException : TaxException
    {

        public NonPermittedNullParameterException(String columnName) : base(columnName)
        {
        }

        public NonPermittedNullParameterException(Type type, String methodName, String parameterName) : base(type.Name + "." + methodName + "." + parameterName)
        {
        }
    }
}
