using System;
using System.Collections.Generic;
using System.Text;

namespace TaxLibrary.datatypes
{
    public class TaxId
    {
        private string value;

        public TaxId(object entity)
        {
            if (entity != null)
            {
                value = entity.ToString();
            }
        }

        public String GetValue()
        {
            return value;
        }


        public override bool Equals(object entity)
        {
            return entity.GetType().IsInstanceOfType(typeof(TaxId)) && (value != null) ? value.Equals(((TaxId)entity).value) : (entity == this);
        }

        public override int GetHashCode()
        {
            return (value != null) ? (typeof(TaxId).GetHashCode() + value.GetHashCode()) : base.GetHashCode();
        }


        public override string ToString()
        {
            return value;
        }

        public static bool isEmpty(TaxId id)
        {
            return id == null || id.value.Trim().Equals("0");
        }
    }

}
