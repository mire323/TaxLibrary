using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TaxLibrary.exception;

namespace TaxLibrary.Exceptions
{

    public class EcmMultipleException : TaxException
    {
        private readonly List<TaxException> exceptions = new List<TaxException>();
        public List<TaxException> Exceptions { get; }

        public void Add(TaxException e)
        {
            exceptions.Add(e);
        }

        public void Remove(TaxException e)
        {
            exceptions.Remove(e);
        }
    }
}

