using System;
using System.Collections.Generic;
using System.Text;
using TaxLibrary.App.Business.Exceptions;

namespace TaxLibrary.Exceptions
{
    public class NullEntityException : BusinessException
    {

        //static {
        //EcmServiceLocator.getTextManager().registerDefaultValue(NullEntityException.class.getName(), "Недефинисан ентитет");
        //}

        public NullEntityException() : base()
        {
        }

        public NullEntityException(params string[] keys) : base(keys)
        {
        }
    }
}
