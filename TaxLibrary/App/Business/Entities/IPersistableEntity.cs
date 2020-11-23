using java.lang;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaxLibrary.App.Business.Entities
{
    public interface IPersistableEntity
    {
        void Insert()
        {
            throw new UnsupportedOperationException();
        }

        void Update()
        {
            throw new UnsupportedOperationException();
        }

        void Delete()
        {
            throw new UnsupportedOperationException();
        }

        void Save()
        {
            throw new UnsupportedOperationException();
        }
    }

}
