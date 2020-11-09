using System;
using System.Collections.Generic;
using System.Text;
using TaxLibrary.exception;

namespace TaxLibrary.data.exceptions
{
    public class DataInstantiationException : TaxException
    {
        public DataInstantiationException(params string[] keys) : base()
        {
            AddKeys(keys);
        }
    }
}
}
