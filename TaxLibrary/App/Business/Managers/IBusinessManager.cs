using System;
using System.Collections.Generic;
using System.Text;
using TaxLibrary.App.Business.Actions;
using TaxLibrary.App.Business.Entities;
using TaxLibrary.App.Business.Filters;
using TaxLibrary.datatypes;
using TaxLibrary.Persistence;

namespace TaxLibrary.App.Business.Managers
{
    public interface IBusinessManager<T> : IStatusable, IClipboardable, IFilterable, IPageable, IPersistable<T> where T : IBusinessEntity
    {
        String GetTitle();

        List<T> GetData();

        long Count();

        QueryResponse<T> GetEditData();

        T GetById(Id id);

        T GetByMasterId(MasterId id);

        T Create();

        List<ColumnDefinition> GetColumnDefinitions();

        void RegisterColumn(ColumnDefinition columnDefinition);

        void UnregisterColumn(String columnName);

        ColumnDefinition FindColumn(String columnName);

        bool HasColumn(String columnName);

        List<TaxFilterItem> getFilterItems();

        List<BusinessManagerAction<T>> GetActions();

        void AddAction(Type actionDefinition);

        void RemoveAction(Type actionDefinition);

        void SetMasterRelation(MasterRelation masterRelation);

        MasterRelation GetMasterRelation();
    }
}
