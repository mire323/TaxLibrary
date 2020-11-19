using System;
using System.Collections.Generic;
using System.Text;
using TaxLibrary.exception;

namespace TaxLibrary.App.Business.Exceptions
{
    public abstract class BusinessException : TaxException
    {

        public BusinessException() : base()
        {
        }

        public BusinessException(params string[] keys) : base(keys)
        {
        }
    }
}
