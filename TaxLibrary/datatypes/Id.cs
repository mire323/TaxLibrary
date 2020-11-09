using System;
using System.Collections.Generic;
using System.Text;

namespace TaxLibrary.datatypes
{
    public class Id : TaxId
    {
        private Id(object entity) : base(entity)
        {
        }

        public static Id of(object entity)
        {
            return new Id(entity);
        }
    }
}
