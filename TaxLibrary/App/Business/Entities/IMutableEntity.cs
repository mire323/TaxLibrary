using java.lang;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaxLibrary.App.Business.Entities
{
    public interface IMutableEntity
    {
        void Set(string columnName, object value)
        {
            throw new UnsupportedOperationException();
        }

    }
}