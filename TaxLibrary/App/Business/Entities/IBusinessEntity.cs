
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TaxLibrary.App.Business.Actions;
using TaxLibrary.entity;

namespace TaxLibrary.App.Business.Entities
{
    public interface IBusinessEntity : IAccessibleBusinessEntity, IMutableBusinessEntity, IPersistableEntity
    {

        public string ToString()
        {
            return ToString();
        }


        List<Type> GetActionsDefinitions();

        void RegisterAction(Type actionDefinition);

        void UnregisterAction(Type actionDefinition);

        BusinessEntityAction<Type> CreateAction(Type entityActionClass);
    }
}
