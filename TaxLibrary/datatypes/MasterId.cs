using System;
using System.Collections.Generic;
using System.Text;

namespace TaxLibrary.datatypes
{
    public class MasterId : TaxId
    {
        private MasterId(object entity) : base(entity)
        {
        }

        public static MasterId of(object entity)
        {
            return new MasterId(entity);
        }
    }
}
