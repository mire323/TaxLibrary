using System;
using System.Collections.Generic;
using System.Text;
using TaxLibrary.App.Business.Entities;
using TaxLibrary.App.Business.Managers;

namespace TaxLibrary.App.Business.Actions
{
    public abstract class BusinessManagerAction<ActionReturnType> : AbstractTaxAction<ActionReturnType>
    {
        private readonly IBusinessManager<IBusinessEntity> businessManager;
        public IBusinessManager<IBusinessEntity> BusinessManager { get; }

        public BusinessManagerAction(TaxActionType type, IBusinessManager<IBusinessEntity> businessManager) : base(type)
        {
            this.businessManager = businessManager;
        }

        public BusinessManagerAction(TaxActionType type, String name, IBusinessManager<IBusinessEntity> businessManager) : this(type, businessManager)
        {
            SetName(name);
        }

    }
}
