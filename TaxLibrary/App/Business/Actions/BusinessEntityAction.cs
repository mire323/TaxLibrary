using System;
using System.Collections.Generic;
using System.Text;

namespace TaxLibrary.App.Business.Actions
{
    public abstract class BusinessEntityAction<EntityType> : AbstractTaxAction<EntityType>
    {
        private readonly EntityType entity;

        public BusinessEntityAction(TaxActionType type, EntityType entity) : base(type)
        {
            this.entity = entity;
        }

        public EntityType getEntity()
        {
            return entity;
        }
    }
}
