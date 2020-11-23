using System;
using System.Collections.Generic;
using System.Text;
using TaxLibrary.App.Business.Filters;

namespace TaxLibrary.App.Business.Managers
{
    public interface IFilterable
    {
        void SetApplicationFilter(TaxFilterItem item);
        void AddApplicationFilter(TaxFilterItem item);
        void AddApplicationFilter(string propertyName, object value);
        void AddApplicationFilter(string propertyName, TaxRelation relation, object value);
        void ClearApplicationFilter();
        void SetFilter(TaxFilterItem item);
        void AddFilter(TaxFilterItem item);
        void AddFilter(string propertyName, object value);
        void AddFilter(string propertyName, TaxRelation relation, object value);
        void ClearFilter();
        void SetUserFilter(TaxFilterItem item);
        void AddUserFilter(TaxFilterItem item);
        void AddUserFilter(string propertyName, object value);
        void AddUserFilter(string propertyName, TaxRelation relation, object value);
        void ClearUserFilter();
        List<TaxFilter> GetFilters();
    }
}
