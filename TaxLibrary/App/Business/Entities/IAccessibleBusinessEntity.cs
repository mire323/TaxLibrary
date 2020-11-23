using System;
using System.Collections.Generic;
using System.Text;
using TaxLibrary.datatypes;

namespace TaxLibrary.entity
{
    public interface IAccessibleBusinessEntity : IAccessibleEntity
    {
        Id GetId();
        MasterId GetMasterId();

        public string SysgetBusinessName()
        {
            return GetType().Name;
        }

        BusinessId SysgetBusinessId()
        {
            return new BusinessId(new EntityType(SysgetBusinessName()), GetId());
        }

        BusinessId SysgetBusinessMasterId()
        {
            return new BusinessId(new EntityType(SysgetBusinessName()), GetMasterId());
        }

        string Dump()
        {
            return ToString();
        }
    }

}
