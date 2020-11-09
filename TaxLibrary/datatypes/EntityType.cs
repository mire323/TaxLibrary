using System;
using System.Collections.Generic;
using System.Text;

namespace TaxLibrary.datatypes
{
    public class EntityType
    {
        private readonly string value;

        public EntityType(Object entity)
        {
            value = entity.ToString();
        }

        public string GetValue()
        {
            return value;
        }

        public override string ToString()
        {
            return value;
        }
    }
}
