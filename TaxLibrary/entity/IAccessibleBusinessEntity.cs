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

        BusinessId sysgetBusinessId()
        {
            return new BusinessId(new EntityType(SysgetBusinessName()), GetId());
        }

        BusinessId sysgetBusinessMasterId()
        {
            return new BusinessId(new EntityType(SysgetBusinessName()), GetMasterId());
        }

        String dump()
        {
            return ToString();
        }
    }

}
